using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sample.Core.Exceptions
{
    [DataContract]
    public class BaseException : Exception
    {
        public BaseException(int code, string message)
        : base(message)
        {
            Code = code;
        }

        public int Code { get; }
    }
}
