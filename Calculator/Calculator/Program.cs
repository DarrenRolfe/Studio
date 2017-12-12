using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var CalcNumeric = new CalcProcesses();
            int CalcCount = 0;

            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine();

            do {
                CalcCount++;

                Console.Write($"Please enter the {CalcCount} number of your calculation: ");
                CalcNumeric.GetUserEntry(Convert.ToString(Console.ReadLine()), 1);

                Console.Write("Please enter the operator for your calculation: ");
                CalcNumeric.GetUserEntry(Convert.ToString(Console.ReadLine()), 2);

            } while((CalcNumeric.CalcResult.Length < 1) && (CalcCount < 5));

            Console.Write("End of Program.");
            Console.ReadKey();
        }
    }
}
