using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCo.IdSharp.ExtException
{
    public enum ValidatorType
    {
        InvalidPair = 1,
        InvalidMethod = 2,
        NotFound404 = 3,
        InvalidCredentials =4,
        BadSignException = 5,
    }

    public static class ValidatorResponse
    {

        public static void Validate(string response, params ValidatorType[] type)
        {
            foreach (var item in type)
            {
                if (response.Contains("invalid_pair") && item == ValidatorType.InvalidPair)
                {
                    throw new InvalidPairException("Invalid Pair");
                }
                else if (response.Contains("invalid method") && item == ValidatorType.InvalidMethod)
                {
                    throw new InvalidMethodException("Invalid Method");
                }
                else if (response.Contains("404 NOT FOUND") && item == ValidatorType.NotFound404)
                {
                    throw new NotFound404Exception("Request Page Not Found");
                }
                else if (response.Contains("Invalid credentials") && item == ValidatorType.InvalidCredentials)
                {
                    throw new InvalidCredentialsException("Invalid credentials. API not found or session has expired.");
                }
                else if (response.Contains("sign") && item == ValidatorType.BadSignException)
                {
                    throw new InvalidCredentialsException("Bad Signature.");
                }
            }
        }
    }
}
