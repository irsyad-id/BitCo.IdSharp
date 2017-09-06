using BitCo.IdSharp.ExtException;
using BitCo.IdSharp.Request;
using BitCo.IdSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.HTTP
{
    public class APIClient
    {
        HttpClient client = new HttpClient();
        private readonly Encoding encoding = Encoding.UTF8;
        string _baseuri = "https://vip.bitcoin.co.id/tapi/";
        string _api_key;
        string _secret_key;

        public APIClient()
        {
            
        }

        public APIClient(string api_key, string secret_key)
        {
            client.BaseAddress = new Uri(_baseuri);
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Library (BitCo.IdSharp; C# / 4.5.2)");
            this._api_key = api_key;
            this._secret_key = secret_key;
        }

        private string CreateSign(string source)
        {
            var keyByte = encoding.GetBytes(_secret_key);
            using (var hmacsha512 = new HMACSHA512(keyByte))
            {
                hmacsha512.ComputeHash(encoding.GetBytes(source));
                return ByteToString(hmacsha512.Hash).ToLower();
            }
        }

        private string ByteToString(byte[] buff)
        {
            string sbinary = "";
            for (int i = 0; i < buff.Length; i++)
                sbinary += buff[i].ToString("X2");
            return sbinary;
        }

        public async Task<string> GetRequest(string url)
        {
            var result = await client.GetAsync(url);
            var content = (await result.Content.ReadAsStringAsync());
            ValidatorResponse.Validate(content, ValidatorType.InvalidPair, ValidatorType.InvalidMethod, ValidatorType.NotFound404);
            return content;
        }

        public async Task<AccountInfoResponse> GetInfoAccountAsync(IBitCoIdRequest request)
        {
            try
            {
                request.request.Headers.TryAddWithoutValidation("Key", _api_key);
                request.request.Headers.TryAddWithoutValidation("Sign", CreateSign(request.request.Content.ReadAsStringAsync().Result));
                var result = await client.SendAsync(request.request);
                return JsonConvert.DeserializeObject<AccountInfoResponse>(result.Content.ReadAsStringAsync().Result);
            }
            catch (BadSignException)
            {
                throw new BadSignException("Bad Signature.");
            }
        }
    }
}
