using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcProcesses
    {

        // DoMathStuff(Calculation, CalcNumber, userentry);
        //             Running Total  Number     Operator
        public void DoMathStuff(decimal Running, decimal AddMe, string OpMe)
        {
            switch (OpMe)
            {
                case "+":
                    Running += AddMe;
                    Console.WriteLine($" ---> {Calculation} + {AddMe} = {Running}");
                    break;
                case "-":
                    Running -= AddMe;
                    Console.WriteLine($" ---> {Calculation} - {AddMe} = {Running}");
                    break;
                case "*":
                    Running *= AddMe;
                    Console.WriteLine($" ---> {Calculation} * {AddMe} = {Running}");
                    break;
                case "/":
                    Running /= AddMe;
                    Console.WriteLine($" ---> {Calculation} / {AddMe} = {Running}");
                    break;
            }
            Calculation = Running;
        }

     //   public int Addition(int firstNumber, int SecondNumber)
     //   {
     //       return firstNumber + SecondNumber;
     //   }

        public CalcProcesses()
        {
            this.CalcReminder = "";
            this.CalcResult = 0;
            this.Calculation = 0;
        }
        public decimal Calculation { get; set; }
        public decimal CalcResult { get; set; }
        public decimal CalcNumber { get; set; }
        public string CalcReminder { get; set; }

        public void GetUserEntry(string userentry)
        {
            if (userentry.Length == 0)
            {
                Console.WriteLine($"End of entries. Thanks for playing...");
                if (Calculation == 0)
                    Calculation++;
                CalcResult = Calculation;
            }
            else
            {
                decimal goodNumber;
                decimal CalcOldValue;
                var isNumber = decimal.TryParse(userentry, out goodNumber);
                var isOldNumber = decimal.TryParse(CalcReminder, out CalcOldValue);

                if (isNumber)
                {
                    // Valid number
                    if ((isOldNumber) && (CalcReminder.Length > 0))
                    {
                        // Last entry was numeric
                        Console.WriteLine("Please now enter an operator!");
                    }
                    else
                    {
                        if (CalcReminder.Length > 0)
                        {
                            CalcNumber = goodNumber;
                            // Do the sum
                            DoMathStuff(Calculation, CalcNumber, CalcReminder);
                            //Console.WriteLine($"DoMathStuff: {Calculation} {CalcReminder} {CalcNumber}");
                        }
                        else
                        {
                            Calculation = goodNumber;
                        }
                        CalcReminder = userentry;
                    }
                }
                else
                {
                    // Operator
                    int setOperator;
                    switch (userentry)
                    {
                        case "+":
                            setOperator = 1;
                            break;
                        case "-":
                            setOperator = 2;
                            break;
                        case "*":
                            setOperator = 3;
                            break;
                        case "/":
                            setOperator = 4;
                            break;
                        default:
                            Console.WriteLine("Unreconised operator. Please supply +, -, * or / only.");
                            setOperator = 0;
                            break;
                    }

                    if ((!isOldNumber) && (CalcReminder.Length > 0) && (setOperator > 0))
                    {
                        // Last entry was operator
                        Console.WriteLine("Last operator replaced, please now enter a number!");
                        CalcReminder = userentry;
                    }
                    else if ((CalcReminder.Length > 0) && (setOperator != 0))
                    {
                        CalcReminder = userentry;
                    }
                    else if (CalcReminder.Length < 1)
                    {
                        Console.WriteLine("Please enter a number first!");
                    }
                }
            }
        }

    }
 }
