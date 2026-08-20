using System;
using static System.Console;
namespace Hello
{
    class helloWorld
    {
        public static void hello(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World");
                return;
            }
            WriteLine("Hello, {0}d", args[0]);
        }
    }
}