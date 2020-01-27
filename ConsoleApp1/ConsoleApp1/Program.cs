using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinQWithArrayOfStrings();

            Console.ReadKey();
        }

        static void LinQWithArrayOfStrings()
        {
            var names = new string[] { "Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby" };

            var query = names.Where(new Func<string, bool>(NoLongerThanFour));

            foreach(string item in query)
            {
                Console.WriteLine(item);
            }
        }

        static bool NoLongerThanFour(string name)
        {
            return name.Length > 4;
        }
    }
}
