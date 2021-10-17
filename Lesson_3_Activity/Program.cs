using System;

namespace Lesson_3_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] toTrim = {'$', '%', ' '};

            {
            
            //calculate savings after the given number of months:

            Console.WriteLine("Initial deposit");
            var deposit = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Savings goal");
            var savingsGoal = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Monthly interest rate(%)");
            var monthlyRateAsPercentage  = double.Parse(Console.ReadLine().Trim(toTrim));
            Console.WriteLine("Term of investment (months)");
            var time = int.Parse(Console.ReadLine());

            var savings = deposit * Math.Pow(1 + (monthlyRateAsPercentage/100),time);

            Console.WriteLine("Your calculated savings are:");
            Console.WriteLine(Math.Round(savings, 2));

            Console.WriteLine("Will you meet your savings goal?");
            var doesMeetSavingsGoal = savings >= savingsGoal;
            Console.WriteLine(doesMeetSavingsGoal);
            

            /*
            //calculate savings compounded annually with term of investment in years:
            Console.WriteLine("Initial deposit");
            var deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Annual interest rate(%)");
            var annualRateAsPercentage  = double.Parse(Console.ReadLine());
            Console.WriteLine("Term of investment (years)");
            var time = int.Parse(Console.ReadLine());

            var savings = deposit * Math.Pow(1 + (annualRateAsPercentage/100),time);

            Console.WriteLine(Math.Round(savings, 2));
            */
            
            /*
            //calculate savings compounded monthly with term of investment in years, i.e. compounded 12 times in 1 year (with regular monthly deposits made at the end of each month):
            Console.WriteLine("Initial deposit");
            var deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Monthly payment");
            var monthlyPayment = double.Parse(Console.ReadLine());
            Console.WriteLine("Annual interest rate(%)");
            var annualRateAsPercentage  = double.Parse(Console.ReadLine());
            Console.WriteLine("Number of times that interest is compounded per year");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Term of investment (years)");
            var time = int.Parse(Console.ReadLine());

            var numberTime = number * time;

            var savings = (deposit * Math.Pow(1 + (annualRateAsPercentage/100/number),numberTime)) + (monthlyPayment * (Math.Pow(1 + (annualRateAsPercentage/100/number),numberTime) - 1)/(annualRateAsPercentage/100/number));

            Console.WriteLine(Math.Round(savings, 2));
            */
            }
            
    
        }
    }
}
