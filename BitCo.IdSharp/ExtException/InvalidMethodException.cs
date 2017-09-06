using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.ExtException
{
    public class InvalidMethodException : Exception
    {
        public InvalidMethodException():base()
        {
        }

        public InvalidMethodException(string message) : base(message)
        {
        }

        public InvalidMethodException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidMethodException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
