// S1.cs
//
// Solution for first Project Euler problem
// Copyright (c) 2018 Balint Gyevnar

using System;
using System.Diagnostics;

namespace ProjectEulerSolutions
{
    /// <summary>
    /// Solution for the first Project Euler problem.
    ///
    /// The problem posed is quite simple, and does not require handling of massive numbers (bound above by 1000),
    /// therefore a brute force solution with simple 32 bit integers suffices.
    ///
    /// The code itself is self-explanatory and works according to the problem description
    /// </summary>
    public sealed class S1 : ISolution
    {
        public string Run()
        {
            Console.Write("Problem 1: ");
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int sum = 0;

            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            sw.Stop();
            Console.Write($"{sum}; ");
            Console.WriteLine($"Elaped time - {sw.Elapsed}");

            return sum.ToString();
        }
    }
}
