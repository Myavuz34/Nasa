using System;
namespace Nasa.App.Exceptions
{
    [Serializable()]
    public class OutOfBoundsException : System.Exception
    {
        public OutOfBoundsException() : base() { }
        public OutOfBoundsException(string message) : base(message) { }
        public OutOfBoundsException(string message, System.Exception inner) : base(message, inner) { }
    }
}
