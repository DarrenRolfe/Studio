using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalcProcesses
    {
        public CalcProcesses()
        {
            this.Calculation = "";
            this.CalcResult = "";
        }
        public string Calculation { get; set; }
        public string CalcResult { get; set; }

        public void GetUserEntry(string userentry, int entrytype)
        {
            if (userentry.Length == 0)
            {
                Console.WriteLine($"End of entry - Sum will be performed.");
                Console.WriteLine($"Entered sum: {Calculation}");
                CalcResult = Calculation;
            }
            else if (userentry.All(char.IsDigit))
            {
                // numeric - type 1
                if (entrytype == 1)
                {
                    Console.WriteLine($"SUM: {Calculation}{userentry}");
                    Calculation += userentry;
                }
                else { Console.WriteLine($"ERROR: {userentry} is not a valid operator!"); }
            }
            else
            {
                // not numeric - type 2
                if (entrytype == 2)
                {
                    Console.WriteLine($"SUM: {Calculation}{userentry}");
                    Calculation += userentry;
                }
                else { Console.WriteLine($"ERROR: {userentry} is not a valid numeric!"); }
            }
        }

    }
 }
