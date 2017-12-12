using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        //public static int firstNumber;
        static void Main(string[] args)
        {
            var CalcNumeric = new CalcProcesses();
            int CalcCount = 0;

     //       var additionValue = CalcNumeric.Addition(1, 2);

            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine();
            Console.WriteLine("Please enter a number, press enter, then enter an operator. Enter a blank line to resolve.");
            Console.WriteLine();

            do
            {
                CalcCount++;
                decimal CalcOldValue;
                var isOldNumber = decimal.TryParse(CalcNumeric.CalcReminder, out CalcOldValue);

                if ((isOldNumber) && (CalcNumeric.CalcReminder.Length >0))
                    Console.Write($"Please enter an operator for your calculation: ");
                else
                    Console.Write($"Please enter a number for your calculation: ");
                CalcNumeric.GetUserEntry(Convert.ToString(Console.ReadLine()));

            } while(CalcNumeric.CalcResult < 1);
            Console.ReadKey();
        }
    }
}
