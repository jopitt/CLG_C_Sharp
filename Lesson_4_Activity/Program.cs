using System;

namespace Lesson_4_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Part 1
            var number = new Random().Next(1, 11);

            Console.WriteLine("Pick a number from 1 to 10: ");
            var guess = int.Parse(Console.ReadLine());

            if(guess == number)
            {
                Console.WriteLine($"Your guess is correct! The number is {number}.");
            }
            else
            {   
                Console.WriteLine($"You guess is incorrect. The number is {number}. Better luck  next time.");
            }
            */

            /*
            //Part 2
            //User has 3 guesses
            //Hints: too low, too high, cold and hot

            var number = new Random().Next(1, 11);
            var allowedGuesses = 3;
            var numberOfGuesses = 0;

            Console.WriteLine("Pick a number from 1 to 10: ");

            while (true)
            {
                var guess = int.Parse(Console.ReadLine());
                var difference = Math.Abs(guess - number);

                numberOfGuesses++;
               
                if (guess == number)
                {  
                    Console.WriteLine($"Your guess is correct! The number is {number}.");
                    break;
                }
                if (difference <= 2 && guess < number)
                {
                    Console.WriteLine("Your guess is hot, but too low!");
                }
                if (difference <= 2 && guess > number)
                {
                    Console.WriteLine("Your guess is hot, but too high!");
                }                         
                if (difference > 2 && guess > number)
                {
                    Console.WriteLine("Your guess is cold, and too high!");
                }
                if (difference > 2 && guess < number)
                {
                    Console.WriteLine("Your guess is cold, and too low!");
                }
                if (numberOfGuesses == allowedGuesses)
                {
                    Console.WriteLine($"The number is: {number}. You have no guesses left. Better luck next time!");
                    break;
                }
                Console.Write($"You have {allowedGuesses - numberOfGuesses} guesses left. Enter another number: ");
            }
            */

            //Extension Activity
            //User has infinite guesses
            var number = new Random().Next(1, 10);
            int guess = 0;
        
            Console.WriteLine("Pick a number from 1 to 10.");

            while (guess != number)
            {
                Console.Write("What is your guess?: ");
                var guessText = int.Parse(Console.ReadLine());
                guess = guessText;
                var difference = Math.Abs(guessText - number);

                if (guess == number)
                {
                    Console.WriteLine($"Your guess is correct! The number is {number}. Thank you for playing.");
                }
                else if (difference <= 2 && guess < number)
                {
                    Console.WriteLine("Your guess is hot, but too low!");
                }
                else if (difference <= 2 && guess > number)
                {
                    Console.WriteLine("Your guess is hot, but too high!");
                }                         
                else if (difference > 2 && guess > number)
                {
                    Console.WriteLine("Your guess is cold, and too high!");
                }
                else
                {
                    Console.WriteLine("Your guess is cold, and too low!");
                }                
            }
        }
    }
}
    