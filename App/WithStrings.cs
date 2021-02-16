using System.Linq;

namespace App
{
    public class WithStrings
    {
        public string GetLastName(string fullName)
        {
            var names = fullName.Split(" ");
            var lastName = names.LastOrDefault();
            return lastName ?? string.Empty;
        }
    }
}
