using System;

namespace Dotnet31NoError
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = new object();
            if (value is not object)
                Console.WriteLine("hello!");
            Console.WriteLine("world!");
        }
    }
}
