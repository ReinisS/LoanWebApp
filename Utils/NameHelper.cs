using System.Collections.Generic;
using System.Linq;

namespace LoanWebApp.Utils
{
    public static class NameHelper
    {
        public static string GetFullName(string firstName, string otherNames, string lastName)
        {
            return string.Join(" ", new List<string>()
                {
                    firstName,
                    otherNames,
                    lastName
                }.Where(s => !string.IsNullOrWhiteSpace(s))
            );
        }
    }
}