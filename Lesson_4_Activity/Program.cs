using System;

namespace Lesson_4_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a number guessing game. Choose how many guesses you'd like to make.");

            Console.WriteLine("For 1 guess only, enter: 1");
            Console.WriteLine("For 3 guesses, enter: 3");
            Console.WriteLine("For infinite guesses, enter: infinite");

            string whichGame = Console.ReadLine().ToLower().Trim();

            switch(whichGame)
            {
                case "1":

                    //Part 1
                    var oneNumber = new Random().Next(1, 11);

                    Console.WriteLine("Pick a number from 1 to 10: ");
                    var guess = int.Parse(Console.ReadLine());

                    if(guess == oneNumber)
                    {
                        Console.WriteLine($"Your guess is correct! The number is {oneNumber}.");
                    }
                    else
                    {   
                      Console.WriteLine($"You guess is incorrect. The number is {oneNumber}. Better luck  next time.");
                    }
                    break;

                case "3":

                    //Part 2
                    //User has 3 guesses
                    //Hints: too low, too high, cold and hot

                    var threeNumber = new Random().Next(1, 11);
                    var allowedGuesses = 3;
                    var numberOfGuesses = 0;

                    Console.WriteLine("Pick a number from 1 to 10: ");

                    while (true)
                    {
                        var threeGuess = int.Parse(Console.ReadLine());
                        var difference = Math.Abs(threeGuess - threeNumber);

                        numberOfGuesses++;
               
                        if (threeGuess == threeNumber)
                        {  
                            Console.WriteLine($"Your guess is correct! The number is {threeNumber}.");
                        break;
                        }
                        if (difference <= 2 && threeGuess < threeNumber)
                        {
                            Console.WriteLine("Your guess is hot, but too low!");
                        }
                        if (difference <= 2 && threeGuess > threeNumber)
                        {
                            Console.WriteLine("Your guess is hot, but too high!");
                        }                         
                        if (difference > 2 && threeGuess > threeNumber)
                        {
                            Console.WriteLine("Your guess is cold, and too high!");
                        }
                        if (difference > 2 && threeGuess < threeNumber)
                        {
                            Console.WriteLine("Your guess is cold, and too low!");
                        }
                        if (numberOfGuesses == allowedGuesses)
                        {
                            Console.WriteLine($"The number is: {threeNumber}. You have no guesses left. Better luck next time!");
                            break;
                        }
                        Console.Write($"You have {allowedGuesses - numberOfGuesses} guesses left. Enter another number: ");
                    }
                    break;

                case "infinite":

                     //Extension Activity
                    //User has infinite guesses
                    var number = new Random().Next(1, 11);
                    int infiniteGuess = 0;
        
                    Console.WriteLine("Pick a number from 1 to 10.");

                    while (infiniteGuess != number)
                    {
                        Console.Write("What is your guess?: ");
                        infiniteGuess = int.Parse(Console.ReadLine());
                        var difference = Math.Abs(infiniteGuess - number);

                        if (infiniteGuess == number)
                        {
                            Console.WriteLine($"Your guess is correct! The number is {number}. Thank you for playing.");
                        }
                        else if (difference <= 2 && infiniteGuess < number)
                        {
                            Console.WriteLine("Your guess is hot, but too low!");
                        }
                        else if (difference <= 2 && infiniteGuess > number)
                        {
                            Console.WriteLine("Your guess is hot, but too high!");
                        }                         
                        else if (difference > 2 && infiniteGuess > number)
                        {
                            Console.WriteLine("Your guess is cold, and too high!");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is cold, and too low!");
                        }   
                    }
                    break;
            }      
         }
    }
}
    
