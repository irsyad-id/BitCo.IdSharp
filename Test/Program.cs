using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitCo.IdSharp.CryptoCoin;
using BitCo.IdSharp.HTTP;
using BitCo.IdSharp.Request;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ETH x IDR");

            ICoinBase coin = new ICoinBase(Pair.ETHxIDR);
            var response = coin.Ticker().GetAwaiter().GetResult();
            Console.WriteLine("Last " + String.Format("{0:N0}",response.ticker.last));
            Console.WriteLine("High " + String.Format("{0:N0}", response.ticker.high));
            Console.WriteLine("Low " + String.Format("{0:N0}", response.ticker.low));
            Console.WriteLine("Current Minimum Buy Market " + String.Format("{0:N0}", response.ticker.buy));
            Console.WriteLine("Current Minimum Sell Market " + String.Format("{0:N0}", response.ticker.sell));


            APIClient _client = new APIClient("MZDZ6ZMW-Z6MFWWME-DS0DDAJA-BNS8VONJ-LAO4IKT5", "11e88b3311eff9977211be590fc3256a4b7c5daf71f77e19d348a599198e82c1272d0e03910195c1");
            var temp = _client.GetInfoAccountAsync(new BitCoIdGetInfoRequest()).GetAwaiter().GetResult();
            Console.WriteLine("\n\nName " + temp.@return.name);
            Console.WriteLine("IDR Balance " + temp.@return.balance.idr);
            Console.WriteLine("BTC Balance " + temp.@return.balance.btc);
            Console.WriteLine("ETH Balance " + temp.@return.balance.eth);

            Console.ReadLine();
        }
    }
}
