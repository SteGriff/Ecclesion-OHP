using System;

namespace Ecclesion.OHP.Core.Exceptions
{
    public class EcclesionException : Exception
    {
        public EcclesionException() : base()
        { }

        public EcclesionException(string message) : base(message)
        { }
    }
}
