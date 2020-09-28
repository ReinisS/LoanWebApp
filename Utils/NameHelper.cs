using System.Collections.Generic;
using System.Linq;

namespace LoanWebApp.Utils
{
    /// <summary>
    /// Helper class for processing person names
    /// </summary>
    public static class NameHelper
    {
        /// <summary>
        /// Concatenates strings of first name, other names and last name together with spaces in-between to form a full name string. Null or whitespace strings are skipped
        /// </summary>
        /// <param name="firstName">Person's first name string</param>
        /// <param name="otherNames">Person's other names (no first name or last name) string</param>
        /// <param name="lastName">Person's last name string</param>
        /// <returns>Concatenated full name string</returns>
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