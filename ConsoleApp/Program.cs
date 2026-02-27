using System;
using System.Net.NetworkInformation;

/* ******************************************* */
/* Exercises 1 - 4: Using the delegate keyword */
/* ******************************************* */

/*namespace ConsoleApp
{
    delegate string CapitalizeDel(string s);
    delegate int CountDel(string s);
    delegate bool CompareDel(string s1, string s2);
    delegate string SortDel(string s);

    class Program
    {
        static void Main(string[] args)
        {
            CapitalizeDel capitalize = (s) => s.ToUpper();
            Console.WriteLine(capitalize("hello world"));

            CountDel countChars = (s) => s.Length;
            Console.WriteLine(countChars("hello world"));

            CompareDel isLongerThan = (s1, s2) => s1.Length > s2.Length;
            Console.WriteLine(isLongerThan("hello", "world"));

            SortDel sortString = (s) => {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            };
            Console.WriteLine(sortString("hello world"));
        }
    }
}*/

/* ********************** */
/* Exercise 5: Using Func */
/* ********************** */

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> capitalizeFunc = s => s.ToUpper();
            Console.WriteLine(capitalizeFunc("hello world"));

            Func<string, int> countFunc = s => s.Length;
            Console.WriteLine(countFunc("hello world"));

            Func<string, string, bool> compareFunc = (s1, s2) => s1.Length > s2.Length;
            Console.WriteLine(compareFunc("hello", "world"));

            Func<string, string> sortFunc = s => {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            };
            Console.WriteLine(sortFunc("hello world"));
        }
    }
}
