using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.Response
{
    public class Trade
    {
        public string date { get; set; }
        public string price { get; set; }
        public string amount { get; set; }
        public string tid { get; set; }
        public string type { get; set; }
        public string error { set; get; }
    }
}
