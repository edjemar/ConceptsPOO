using System.Runtime.Serialization;

namespace ConceptsPOO
{
    [Serializable]
    internal class MontException : Exception
    {
        public MontException()
        {
        }

        public MontException(string? message) : base(message)
        {
        }

        public MontException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MontException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}