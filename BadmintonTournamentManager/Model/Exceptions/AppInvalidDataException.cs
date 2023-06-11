using System.Runtime.Serialization;

namespace BadmintonTournamentManager.Model.Exceptions
{
    public class AppInvalidDataException : ArgumentException
    {
        public AppInvalidDataException()
        {
        }

        public AppInvalidDataException(string? message) : base(message)
        {
        }

        public AppInvalidDataException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public AppInvalidDataException(string? message, string? paramName) : base(message, paramName)
        {
        }

        public AppInvalidDataException(string? message, string? paramName, Exception? innerException) : base(message, paramName, innerException)
        {
        }

        protected AppInvalidDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
