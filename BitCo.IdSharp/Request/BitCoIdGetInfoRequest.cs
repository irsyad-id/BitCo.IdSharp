using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.Request
{
    public class BitCoIdGetInfoRequest : IBitCoIdRequest
    {
        public BitCoIdGetInfoRequest()
        {
            request.Method = HttpMethod.Post;
            request.Content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("method", "getInfo"),
                new KeyValuePair<string, string>("nonce", (UtcNowTicks+new Random().Next(1000,9999)).ToString())
            });
        }
    }
}
