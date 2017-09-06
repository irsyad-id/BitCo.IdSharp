using BitCo.IdSharp.ExtException;
using BitCo.IdSharp.HTTP;
using BitCo.IdSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.CryptoCoin
{
    public class ICoinBase
    {
        protected APIClient api = new APIClient();

        public string codename { set; get; }
        protected string public_api_url = "https://vip.bitcoin.co.id/api/";

        public ICoinBase(Pair pcodename)
        {
            codename = EnumUtils.stringValueOf(pcodename);
        }

        public async virtual Task<TickerCoinResponse> Ticker()
        {
            var result = await api.GetRequest($"{public_api_url}{codename}/ticker");
            return JsonConvert.DeserializeObject<TickerCoinResponse>(result);
        }

        public async virtual Task<List<Trade>> Trades()
        {
            var result = await api.GetRequest($"{public_api_url}{codename}/trades");
            return JsonConvert.DeserializeObject<List<Trade>>(result);
        }

        public async virtual Task<DepthCoinResponse> Depth()
        {
            var result = await api.GetRequest($"{public_api_url}{codename}/depth");
            return JsonConvert.DeserializeObject<DepthCoinResponse>(result);
        }
    }
}
