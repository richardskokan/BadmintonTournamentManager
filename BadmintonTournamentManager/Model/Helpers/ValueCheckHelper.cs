using BadmintonTournamentManager.Model.Exceptions;

namespace BadmintonTournamentManager.Model.Helpers
{
    public static class ValueCheckHelper
    {
        public static void CheckObjectExists(object? obj, string context)
        {
            if (obj == null)
                throw new AppInvalidDataException($"""The {context} does not exist.""");
        }

        public static void CheckString(string value, string context)
        {
            if (string.IsNullOrEmpty(value))
                throw new AppInvalidDataException($"""The {context} value "{value}" is invalid.""");
        }

        public static void CheckDateSuccession(DateTime? first, DateTime? second)
        {
            if (first == null || second == null)
                return;

            if (first > second)
                throw new AppInvalidDataException("The date combination is invalid.");
        }

        public static void CheckDateInRange(DateTime dateToCheck, DateTime rangeStart, DateTime rangeEnd)
        {
            if (dateToCheck < rangeStart || dateToCheck > rangeEnd)
                throw new AppInvalidDataException($"""The specified date {dateToCheck:d. M. yyyy} """ +
                                                  $"""is not in range {rangeStart:d. M. yyyy}-{rangeEnd:d. M. yyyy}""");
        }
    }
}
