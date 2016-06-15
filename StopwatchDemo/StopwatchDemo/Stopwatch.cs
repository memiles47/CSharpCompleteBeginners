using System;

namespace StopwatchDemo
{
    internal class Stopwatch
    {
        private DateTime _startTime;

        public void Start()
        {
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            var time = DateTime.Now - _startTime;
            Console.WriteLine($"Elapsed Time: {time.Seconds} seconds, {time.Milliseconds} millisecoonds");
        }
    }
}