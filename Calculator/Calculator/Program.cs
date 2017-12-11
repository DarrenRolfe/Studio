using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public char CalcOp { get; }
        public decimal CalcValue { get; }
        public Calc(decimal calcvalue, char calcop)
        {
            this.CalcValue = calcvalue;
            this.CalcOp = calcop;
        }
    }

    public GetUserEntry(string userentry)
    {
        //userentry = Convert.ToString(Console.ReadLine());
        if (!userentry.All(char.IsDigit))
        {
            // not numeric
            Console.WriteLine($"The value {userentry} is not numeric!");
        }
        else
        {
            // numeric
            Console.WriteLine($"The value {userentry} is a numeric value!");
        }
    }


    class Program
    {
        // public List<Calc> allCalcs = new List<Calc>();
        static void Main(string[] args)
        {
            //String userentry = "";
            //string UE = "";
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine();

            Console.Write("Please enter the first numeric of your calculation: ");
            UE = Convert.ToString(Console.ReadLine());
            GetUserEntry(Console.ReadLine());


            Console.ReadKey();
/*
            Console.Write("Please enter your calculation here: ");
            userentry = Convert.ToString(Console.ReadLine());
            decimal count = 1;
            decimal result;
            foreach (var item in userentry)
            {
                if (count % 2 == 0)
                {
                    if (decimal.TryParse(item, out result))
                        throw new InvalidOperationException($"Error: [{item}] Numeric value expected.");  // dec
                } else {
                    if (item.GetType != char)
                        throw new InvalidOperationException($"Error: [{item}] Operator character expected."); // not dec
                }
                var 
                count++;
            }

            List<Calc>
            */
        }
    }
}
