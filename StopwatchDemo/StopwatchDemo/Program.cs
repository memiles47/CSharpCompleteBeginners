using System;

namespace StopwatchDemo
{
    class Program
    {
        static void Main()
        {
            var timer = new Stopwatch();

            Console.WriteLine("Press <Enter> to start the timeer");
            Console.ReadLine();
            timer.Start();
            
            Console.WriteLine("Press <Enter> to stop the timer");
            Console.ReadLine();
            timer.Stop();

            Console.ReadLine();
        }
    }
}