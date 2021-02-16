using System;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nameParser = new JustStringThings();
            var lastname = nameParser.GetLastName("upendra singh gusain");

            Console.WriteLine(lastname);
            Console.ReadLine();
        }
    }
}
