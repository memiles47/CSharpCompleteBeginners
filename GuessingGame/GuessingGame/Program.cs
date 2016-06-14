﻿using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            int guess;
            var randomNumber = new Random();
            var answer = randomNumber.Next(1, 101);

            do
            {
                Console.Write("Guess a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());

                if (guess != answer)
                    Console.WriteLine($"Your guess is {(guess < answer ? "Low" : "High")}"); 

            } while (answer != guess);

            Console.WriteLine($"You guessed the answer of {guess} correctly");
            Console.ReadLine();
        }
    }
}