using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UC6_Simulate_Stopwatch_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Choose the option 1 to start : ");
            int start = Convert.ToInt32(Console.ReadLine());
            if (start == 1)
            {
                // Begin timing
                stopwatch.Start();
            }

            // Do something
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(10);
            }
            Console.WriteLine("Choose the option 2 to start : ");
            int stop = Convert.ToInt32(Console.ReadLine());
            if (stop == 2)
            {
                // Stop timing
                stopwatch.Stop();
            }

            // Write result
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
            Console.ReadLine(); 
        }
    }
}
