using System.Collections.Generic;

namespace AoC_Day10_1
{
    public class AoCPuzzle
    {
        public int PuzzleLength { get; set; }
        public int PuzzleSkip { get; set; }
        public int PuzzlePosition { get; set; }

        public List<AoCPuzzleArray> PuzzleArray = new List<AoCPuzzleArray>();
        public List<AoCPuzzleArray> PuzzleInput = new List<AoCPuzzleArray>();
        public List<AoCPuzzleArray> PuzzlePart = new List<AoCPuzzleArray>();

        public int Init;

        public void PopulateArray()
        {
            // Set overall puzzle length
            for (Init = 0; Init < 256; Init++)
                //for (Init = 0; Init < 5; Init++)
            {
                var newValue = new AoCPuzzleArray(Init);
                PuzzleArray.Add(newValue);
                //Console.Write($" [{Init} / {PuzzleArray[Init].Value}] ");
            }
            Init = 0;
            // Set puzzle input
            foreach (int rep in new []{165, 1, 255, 31, 87, 52, 24, 113, 0, 91, 148, 254, 158, 2, 73, 153})

        //foreach (int rep in new int[4] {3, 4, 1, 5})
                {
                    var newValue = new AoCPuzzleArray(rep);
                PuzzleInput.Add(newValue);
                //Console.Write($" [{rep} / {PuzzleInput[Init].Value}] ");
                Init++;
            }
        }

        public void AoC_PullLength(int pos, int len)
        {
            if (PuzzlePart.Count > 0)
                PuzzlePart.Clear();
            //int Init = 0;
            //Console.WriteLine();
            //Console.Write($" Sample of Array Length (Len:{len}): ");
            for (Init = 0; Init < len; Init++, pos++)
            {
                if (pos == PuzzleArray.Count)
                    pos = 0;
                var newValue = new AoCPuzzleArray(PuzzleArray[pos].Value);
                PuzzlePart.Add(newValue);
                //Console.Write($" [#{Init} / pos:{pos} / VALUE:{PuzzlePart[Init].Value}] ");
            }
            //Console.WriteLine();
        }

        public void AoC_ReverseLength()
        {
            PuzzlePart.Reverse();

            //int len = PuzzleLength;
            //int pos = Puzzleposition;
            //Console.WriteLine();
            //Console.Write($" Reversing Array Length (len:{len}): ");

            //for (Init = 0; Init < len; Init++, pos++)
            //{
            //    if (pos == PuzzleArray.Count)
            //        pos = 0;
            //    var newValue = new AoCPuzzleArray(PuzzleArray[pos].Value);
            //    Console.Write($" [#{Init} / pos:{pos} / VALUE:{PuzzlePart[Init].Value}] ");
            //}
            //Console.WriteLine();
        }

        public void AoC_PushLength(int pos, int len)
        {
            //Console.WriteLine();
            //Console.Write($" Applying new Array data (Len:{len}): ");
            for (Init = 0; Init < PuzzlePart.Count; Init++, pos++)
            {
                if (pos == PuzzleArray.Count)
                    pos = 0;
                //var newValue = new AoCPuzzleArray(PuzzlePart[Init].Value);
                PuzzleArray[pos].Value = PuzzlePart[Init].Value;
                //Console.Write($" [#{Init} / pos:{pos} / VALUE:{PuzzlePart[Init].Value}] ");
            }
            //Console.WriteLine();
        }
    }

    public class AoCPuzzleArray
    {
        public int Value { get; set; }
        public AoCPuzzleArray(int value)
        {
            Value = value;
        }
    }

}
