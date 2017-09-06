using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.Response
{
    public class Ticker
    {
        public double high { get; set; }
        public double low { get; set; }
        public string vol_btc { get; set; }
        public string vol_idr { get; set; }
        public double last { get; set; }
        public double buy { get; set; }
        public double sell { get; set; }
        public int server_time { get; set; }
        
    }

    public class TickerCoinResponse
    {
        public Ticker ticker { get; set; }
        public string error { set; get; }
    }
}
