using System.Runtime.Serialization;

namespace Sample.Core.Exceptions
{
    [DataContract]
    public class My502Exception : BaseException
    {
        public My502Exception(int code, string message)
                : base(code, message)
        {

        }
    }
}
