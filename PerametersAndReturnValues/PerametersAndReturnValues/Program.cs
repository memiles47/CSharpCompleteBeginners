using System;

namespace PerametersAndReturnValues
{
    class Program
    {
        static void Main()
        {
            var  calc = new SimpleCalculator();

            Console.WriteLine($"The Square of four is: {calc.Square(4)}");

            Console.ReadLine();
        }
    }
}
