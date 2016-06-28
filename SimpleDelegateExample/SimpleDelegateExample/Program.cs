using System;

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
            Console.WriteLine(myDelegate(272, 153));
        }

        static void Main()
        {
           Func<int, int, int> myDelegate = Add;

            Console.WriteLine(myDelegate(271, 152));

            CallDelegate(myDelegate);

            Console.ReadLine();

        }
    }
}