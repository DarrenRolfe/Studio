using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Day10_1
{
    class AoC_Puzzle
    {
        public int PuzzleLength { get; set; }
        public int PuzzleSkip { get; set; }
        public int PuzzlePosition { get; set; }

        public List<AoC_PuzzleArray> PuzzleArray = new List<AoC_PuzzleArray>();
        public List<AoC_PuzzleArray> PuzzleInput = new List<AoC_PuzzleArray>();
        public List<AoC_PuzzleArray> PuzzlePart = new List<AoC_PuzzleArray>();

        int init = 0;

        public void PopulateArray()
        {
            // Set overall puzzle length
            for (init = 0;init < 256;init++)
            //for (init = 0; init < 5; init++)
                {
                    var newValue = new AoC_PuzzleArray(init);
                PuzzleArray.Add(newValue);
                //Console.Write($" [{init} / {PuzzleArray[init].Value}] ");
            }
            init = 0;
            // Set puzzle input
            foreach (int rep in new int[16]{165, 1, 255, 31, 87, 52, 24, 113, 0, 91, 148, 254, 158, 2, 73, 153})
            //foreach (int rep in new int[4] {3, 4, 1, 5})
                {
                    var newValue = new AoC_PuzzleArray(rep);
                PuzzleInput.Add(newValue);
                //Console.Write($" [{rep} / {PuzzleInput[init].Value}] ");
                init++;
            }
        }

        public void AoC_PullLength(int Pos, int Len)
        {
            if (PuzzlePart.Count > 0)
                PuzzlePart.Clear();
            int init = 0;
            //Console.WriteLine();
            //Console.Write($" Sample of Array Length (Len:{Len}): ");
            for (init = 0; init < Len; init++, Pos++)
            {
                if (Pos == PuzzleArray.Count)
                    Pos = 0;
                var newValue = new AoC_PuzzleArray(PuzzleArray[Pos].Value);
                PuzzlePart.Add(newValue);
                //Console.Write($" [#{init} / POS:{Pos} / VALUE:{PuzzlePart[init].Value}] ");
            }
            //Console.WriteLine();
        }

        public void AoC_ReverseLength()
        {
            PuzzlePart.Reverse();
            /* /
            int Len = PuzzleLength;
            int Pos = PuzzlePosition;
            Console.WriteLine();
            Console.Write($" Reversing Array Length (Len:{Len}): ");

            for (init = 0; init < Len; init++, Pos++)
            {
                if (Pos == PuzzleArray.Count)
                    Pos = 0;
                var newValue = new AoC_PuzzleArray(PuzzleArray[Pos].Value);
                Console.Write($" [#{init} / POS:{Pos} / VALUE:{PuzzlePart[init].Value}] ");
            }
            Console.WriteLine();
            //*/
        }

        public void AoC_PushLength(int Pos, int Len)
        {
            //Console.WriteLine();
            //Console.Write($" Applying new Array data (Len:{Len}): ");
            for (init = 0; init < PuzzlePart.Count; init++, Pos++)
            {
                if (Pos == PuzzleArray.Count)
                    Pos = 0;
                var newValue = new AoC_PuzzleArray(PuzzlePart[init].Value);
                PuzzleArray[Pos].Value = PuzzlePart[init].Value;
                //Console.Write($" [#{init} / POS:{Pos} / VALUE:{PuzzlePart[init].Value}] ");
            }
            //Console.WriteLine();
        }
    }

    class AoC_PuzzleArray
    {
        public int Value { get; set; }
        public AoC_PuzzleArray(int value)
        {
            this.Value = value;
        }
    }

}
