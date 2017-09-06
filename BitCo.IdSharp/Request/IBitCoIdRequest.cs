using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BitCo.IdSharp.Request
{
    public class IBitCoIdRequest
    {
        public HttpRequestMessage request = new HttpRequestMessage();

        public IBitCoIdRequest()
        {
            
        }

        private long lastTimeStamp = DateTime.UtcNow.Ticks;
        public long UtcNowTicks
        {
            get
            {
                long original, newValue;
                do
                {
                    original = lastTimeStamp;
                    long now = DateTime.UtcNow.Ticks;
                    newValue = Math.Max(now, original + 1);
                } while (Interlocked.CompareExchange(ref lastTimeStamp, newValue, original) != original);
                return newValue;
            }
        }
    }
}
