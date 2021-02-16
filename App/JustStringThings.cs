using System;
using System.Linq;

namespace App
{
    public class JustStringThings
    {
        public string GetLastName(string fullName)
        {
            var names = fullName.Split(" ");
            var lastName = names.LastOrDefault();
            return lastName ?? string.Empty;
        }

        public string GetLastNameUsingSubstring(string fullName)
        {
            var lastSpaceIndex = fullName.LastIndexOf(" ", StringComparison.Ordinal);

            return lastSpaceIndex == -1
                ? string.Empty
                //total allocations accounts for the surname string we’re allocating when calling substring.
                : fullName.Substring(lastSpaceIndex + 1);
        }

        public ReadOnlySpan<char> GetLastNameWithSpan(ReadOnlySpan<char> fullName)
        {
            var lastSpaceIndex = fullName.LastIndexOf(' ');

            return lastSpaceIndex == -1
                ? ReadOnlySpan<char>.Empty
                : fullName.Slice(lastSpaceIndex + 1);
        }
    }
}
