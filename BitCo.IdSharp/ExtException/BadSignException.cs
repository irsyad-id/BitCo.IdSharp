using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.ExtException
{
    public class BadSignException : Exception
    {
        public BadSignException() : base()
        {
        }

        public BadSignException(string message) : base(message)
        {

        }

        public BadSignException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BadSignException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
