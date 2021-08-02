using Sample.Core.Exceptions;
using System;

namespace Sample.Core
{
    public class Result<T>
    {
        public bool HasData { get; set; }

        public T Data { get; set; }

        public BaseException Error { get; set; }
    }
}
