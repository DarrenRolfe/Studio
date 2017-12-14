using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Day10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Puzzle = new AoC_Puzzle();

            //Console.WriteLine($" Populate Arrays: ");
            Puzzle.PopulateArray();
            //Console.WriteLine();

            foreach (var entry in Puzzle.PuzzleInput)
            {
                // This will repeat for each length in the PuzzleInput

                // Collect length into list
                Puzzle.PuzzleLength = entry.Value;
                Puzzle.AoC_PullLength(Puzzle.PuzzlePosition, Puzzle.PuzzleLength);
                //Console.WriteLine(Puzzle.PuzzlePart);

                // Reverse the list order
                Puzzle.AoC_ReverseLength();

                // Submit new list back into main list
                Puzzle.AoC_PushLength(Puzzle.PuzzlePosition, Puzzle.PuzzlePart.Count);

                Puzzle.PuzzlePosition += Puzzle.PuzzleLength + Puzzle.PuzzleSkip;
                while (Puzzle.PuzzlePosition > Puzzle.PuzzleArray.Count) {
                    Puzzle.PuzzlePosition -= Puzzle.PuzzleArray.Count;
                }
                Puzzle.PuzzleSkip++;
            }

            // Show contents of PuzzleArray
            var output = "";
            var multiply = 1;
            for (var init = 0; init < Puzzle.PuzzleArray.Count; init++)
            {
                var newValue = Puzzle.PuzzleArray[init];
                output += " "+newValue.Value;

                // Multiply first two values
                if (init < 2)
                //if ((init == 3) || (init == 2))
                {
                    multiply *= newValue.Value;
                }
            }
            Console.WriteLine($" Puzzle: {output}");
            Console.WriteLine();
            Console.WriteLine($" Puzzle Skip: {Puzzle.PuzzleSkip}");
            Console.WriteLine();
            Console.WriteLine($" Puzzle Solution is: {multiply}");

            Console.ReadKey();
        }
    }
}
