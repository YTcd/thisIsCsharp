using System;
using static System.Console;
namespace Hello
{
    class helloWorld
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World");
                return;
            }
            WriteLine("Hello, {0}", args[0]);
        }
    }
}