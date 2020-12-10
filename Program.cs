
using System;


namespace MemoryOptimization
{
    class Program
    {

        static void oldalg()
        {
            {
                int[,] AM = new int[2, 2];
                int res = 0;

                for (int j = 500000000; j > 0; j--)
                {
                    AM[0, 0]++;
                    AM[0, 0]++;
                }

                AM[1, 1] = AM[0, 0];

                Console.WriteLine(AM[0, 0]);

            }
        }

        static void newalg()
        {

            int[,] AM = new int[2, 2];
            // int res = 0;

            for (int j = 500000000; j > 0; j--)
            {
                AM[0, 0] += 2;
                // AM[0,0]++;
            }

            // AM[1,1] = AM[0,0];

            Console.WriteLine(AM[0, 0]);


        }


        static void Main(string[] args)
        {

            var timing = System.Diagnostics.Stopwatch.StartNew();
            oldalg();
            Console.WriteLine($"Calculating time  {timing.ElapsedMilliseconds} milsec.\n");
            timing = System.Diagnostics.Stopwatch.StartNew();
            newalg();
            Console.WriteLine($"Calculating time {timing.ElapsedMilliseconds} milsec.\n");


        }
    }
}
