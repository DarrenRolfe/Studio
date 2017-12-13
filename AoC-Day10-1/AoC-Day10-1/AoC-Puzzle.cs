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
        //int init = 0;

        public void PopulateArray()
        {
            for (var init = 0;init < 256;init++)
            {
                var newValue = new AoC_PuzzleArray(init);
                PuzzleArray.Add(newValue);
                //Console.Write($" [{init} / {PuzzleArray[init].Value}] ");
            }
            //init = 0;
            foreach (int rep in new int[16]{165, 1, 255, 31, 87, 52, 24, 113, 0, 91, 148, 254, 158, 2, 73, 153})
            {
                var newValue = new AoC_PuzzleArray(rep);
                PuzzleInput.Add(newValue);
                //Console.Write($" [{init} / {rep} / {PuzzleInput[init].Value}] ");
                //init++;
            }
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
