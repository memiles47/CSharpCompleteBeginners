using System;

namespace PerametersAndReturnValues
{
    internal class Program
    {
        private static void Main()
        {
            var  calc = new SimpleCalculator();

            Console.WriteLine($"The Square of four is: {calc.Square(4)}");

            Console.WriteLine($"The Square of a float 4.5 is: {calc.Square(4.5f)}"); 

            Console.Write("Enter first number to multiply: ");
            float tempParse;
            var numberOne = float.TryParse(Console.ReadLine(), out tempParse) ? tempParse : 0;

            Console.Write("Enter first number to multiply: ");
            var numberTwo = float.TryParse(Console.ReadLine(), out tempParse) ? tempParse : 0;

            Console.WriteLine($"The product of those two numbers is: {calc.Multiply(numberOne, numberTwo)}");
            Console.ReadLine();
        }
    }
} 
