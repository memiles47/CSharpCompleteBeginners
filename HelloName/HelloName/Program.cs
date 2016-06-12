using System;

namespace HelloName
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine($"\nHello, {name}");
            Console.ReadLine();
        }
    }
}
