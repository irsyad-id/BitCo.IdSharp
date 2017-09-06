using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.ExtException
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException():base()
        {
        }

        public InvalidCredentialsException(string message) : base(message)
        {
        }

        public InvalidCredentialsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidCredentialsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
