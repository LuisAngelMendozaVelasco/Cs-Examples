//Access characters in a string by referring to its index number

using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";

            Console.WriteLine(myString[0]);
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}