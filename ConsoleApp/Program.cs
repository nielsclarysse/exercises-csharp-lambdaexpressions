using System;
using System.Collections.Generic;
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

/*namespace ConsoleApp
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
}*/

/* ********************** */
/* Exercise 6: Using Func */
/* ********************** */

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "apple", "pear", "banana", "strawberry", "lemon" };

            fruits.Where(s => StringMinLength(s, 6))
                  .ToList()
                  .ForEach(f => Console.WriteLine(f));
        }

        static bool StringMinLength(string s, int min) => s.Length >= min;
    }

    // Extension methods written in the classic way.
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (T item in source)
            {
                if (predicate(item)) yield return item;
            }
        }

        public static List<T> ToList<T>(this IEnumerable<T> source)
        {
            List<T> list = new List<T>();
            foreach (T item in source)
            {
                list.Add(item);
            }
            return list;
        }
    }
}
