using System;

namespace Lesson_6_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
			// display title as the C# console calculator app.
			Console.WriteLine("Basic calculator\r");
			Console.WriteLine("----------------\n");
			
			while(true)
			{
				double num1 = 0;
				double num2 = 0;
			
				//ask for first number
				Console.WriteLine("Type a number, and then press Enter:");
				//create variable if input is a string
				var num1AsString = Console.ReadLine();
				//if input is not a number
				while(!Double.TryParse(num1AsString, out num1))
				{
					Console.WriteLine("This is not a number. Enter a number:");
					num1AsString = Console.ReadLine();
				}
				
				
				//ask for second number
				Console.WriteLine("Type another number, and then press Enter:");
				//create variable if input is a string
				var num2AsString = Console.ReadLine();
				//if input is not a number
				while(!Double.TryParse(num2AsString, out num2))
				{
					Console.WriteLine("This is not a number. Enter a number:");
					num2AsString = Console.ReadLine();
				}		

				//operator options
				GiveOptions();
				string option = Console.ReadLine().ToLower();

				//calculate and output result
				RespondToUserCommand(option, num1, num2);
				
				//provide option to continue with the calculator or exit			
				Console.WriteLine("Hit Enter to continue (otherwise enter x to close the calculator).");
				var exitOption = Console.ReadLine().ToLower().Trim();
				
				if(exitOption == "x")
				{
					Console.WriteLine("You have closed the calculator.");
					break;
				}
				else
				{
					continue;
				}
			}
			
			static void GiveOptions()
			{
				
				Console.WriteLine("Choose an option from the following list:");
				Console.WriteLine("\ta - Add");
				Console.WriteLine("\ts - Subtract");
				Console.WriteLine("\tm - Multiply");
				Console.WriteLine("\td - Divide");
				Console.Write("Your option is: ");
			}
			
			static void RespondToUserCommand(string option, double num1, double num2)
			{
				switch (option)
				{
					case "a":
						Add(num1, num2);
						break;
					case "s":
						Subtract(num1, num2);
						break;
					case "m":
						Multiply(num1, num2);
						break;
					case "d":
						Divide(num1, num2);
						break;
					default:
						Console.WriteLine("Please enter a valid option.");
						break;
				}
			}
			
			static void Add(double num1, double num2)
			{
				Console.WriteLine($"Result: {num1} + {num2} = " + Math.Round((num1 + num2), 2));
			}
			
			static void Subtract(double num1, double num2)
			{
				Console.WriteLine($"Result: {num1} - {num2} = " + Math.Round((num1 - num2), 2));
			}
			
			static void Multiply(double num1, double num2)
			{
				Console.WriteLine($"Result: {num1} * {num2} = " + Math.Round((num1 * num2), 2));
			}
			
			static void Divide(double num1, double num2)
			{
				//if 0 is entered as a divisor
				while(num2 == 0)
				{
					Console.WriteLine("You can't divide by 0. Enter another number:");
					num2 = Convert.ToDouble(Console.ReadLine());
				}
				Console.WriteLine($"Result: {num1} / {num2} = " + Math.Round((num1 / num2), 2));
			}	
		}        
	}
}
