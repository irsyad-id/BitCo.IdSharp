using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.ExtException
{
    public class NotFound404Exception : Exception
    {
        public NotFound404Exception():base()
        {
        }

        public NotFound404Exception(string message) : base(message)
        {
        }

        public NotFound404Exception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFound404Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
