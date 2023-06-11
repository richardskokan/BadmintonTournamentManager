using System.Runtime.Serialization;

namespace BadmintonTournamentManager.Model.Exceptions
{
    public class AppDataLoadException : FileLoadException
    {
        public AppDataLoadException() { }

        public AppDataLoadException(string? message) : base(message) { }

        public AppDataLoadException(string? message, Exception? inner) : base(message, inner) { }

        public AppDataLoadException(string? message, string? fileName) : base(message, fileName) { }

        public AppDataLoadException(string? message, string? fileName, Exception? inner) : base(message, fileName, inner) { }

        protected AppDataLoadException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
