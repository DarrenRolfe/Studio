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
            Puzzle.PopulateArray();

            foreach (var entry in Puzzle.PuzzleInput)
            {
                // This will repeat for each length in the PuzzleInput

                // Reverse length
                Puzzle.PuzzlePart = AoC_PullLength(Puzzle.PuzzlePosition,Puzzle.PuzzleLength);
                // AoC_ReverseLength();
                // AoC_PushLength();

                Puzzle.PuzzlePosition += Puzzle.PuzzleLength + Puzzle.PuzzleSkip;
                while (Puzzle.PuzzlePosition > 255) {
                    Puzzle.PuzzlePosition -= 255;
                }
                Puzzle.PuzzleSkip++;
            }

            // Show contents of PuzzleArray
            var output = "";
            var multiply = 1;
            for (var init = 0; init < 256; init++)
            {
                var newValue = new AoC_PuzzleArray(init);
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
