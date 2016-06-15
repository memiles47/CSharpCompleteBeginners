using System;

namespace StopwatchDemo
{
    class Stopwatch
    {
        private DateTime StartTime { get; set; }

        public void Start()
        {
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            var time = DateTime.Now - StartTime;
            Console.WriteLine($"Elapsed Time: {time.Seconds} seconds, {time.Milliseconds} millisecoonds");
        }
    }
}