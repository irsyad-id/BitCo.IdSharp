using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.ExtException
{
    public class InvalidPairException : Exception
    {
        public InvalidPairException():base()
        {
        }

        public InvalidPairException(string message) : base(message)
        {
        }

        public InvalidPairException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidPairException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
