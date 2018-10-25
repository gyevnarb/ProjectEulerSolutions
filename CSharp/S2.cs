// S2.cs
//
// Solution for second Project Euler problem
// Copyright (c) 2018 Balint Gyevnar

using System;
using System.Linq;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// Solution for second Project Euler problem
    ///
    /// Calculate Fibonacci numbers using bottom-up dynamic programming algorithm until limit is reached.
    /// Code runs in linear time with respect to the size of the fib-array, but the loop is also limited by the cutoff.
    /// </summary>
    public sealed class S2 : ISolution
    {
        public string Run()
        {
            Console.Write("Problem 2: ");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            long[] fib = Enumerable.Repeat(-1L, 50).ToArray(); // Size large enough, that F_n > 4x10^6 is reached

            fib[0] = 0;
            fib[1] = 1;

            long total = 0;

            for (int i = 0; i < fib.Length; i++)
            {
                // Calculate following Fibonacci number
                if (fib[i] < 0)
                    fib[i] = fib[i - 1] + fib[i - 2];

                if (fib[i] > 4e6) break;

                if (fib[i] % 2 == 0)
                    total += fib[i];
            }

            sw.Stop();
            Console.Write($"{total}; ");
            Console.WriteLine($"Elaped time - {sw.Elapsed}");

            return total.ToString();
        }
    }
}
