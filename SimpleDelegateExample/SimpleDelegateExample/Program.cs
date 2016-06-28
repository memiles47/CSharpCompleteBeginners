﻿using System;

namespace SimpleDelegateExample
{
    class Program
    {
        //public delegate int MyDelegate(int a, int b);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static void CallDelegate(Func<int, int, int> myDelegate)
        {
            Console.WriteLine($"{myDelegate(272, 153)}\n");
        }

        static void Main()
        {
           Func<int, int, int> myDelegate = Add;

            Console.WriteLine($"{myDelegate(271, 152)}");

            CallDelegate(myDelegate);

            Func<string, int, int, string> ShowMe = (a, b, c) => string.Format(a, b, c, (b + c));
            Console.WriteLine($"Result of calling the \'ShowMe\' Function: {ShowMe("{0} + {1} = {2}", 3, 5)}");

            Console.ReadLine();

        }
    }
}