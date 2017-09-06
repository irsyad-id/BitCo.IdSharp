using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.Response
{
    public class DepthCoinResponse
    {
        public List<List<object>> buy { get; set; }
        public List<List<object>> sell { get; set; }
        public string error { set; get; }
    }
}
