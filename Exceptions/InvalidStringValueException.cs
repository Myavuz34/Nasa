namespace Nasa.App.Exceptions
{
    public class InvalidStringValueException : System.Exception
    {
        public InvalidStringValueException() : base() { }
        public InvalidStringValueException(string message) : base(message) { }
        public InvalidStringValueException(string message, System.Exception inner) : base(message, inner) { }
    }
}
