using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_Day10_1
{
    class AoC_ReverseLength
    {

        public AoC_ReverseLength()
        {
           
        }

        public AoC_PullLength(int Pos, int Len)
        {
            List<AoC_PuzzleArray> PullLength = new List<AoC_PuzzleArray>();

            // demo
            foreach (int rep in new int[16] { 165, 1, 255, 31, 87, 52, 24, 113, 0, 91, 148, 254, 158, 2, 73, 153 })
            {
                var newValue = new AoC_PuzzleArray(rep);
                PullLength.Add(newValue);
                //Console.Write($" [{init} / {rep} / {PuzzleInput[init].Value}] ");
                //init++;
            }

            return PullLength;
        }

    }
}
