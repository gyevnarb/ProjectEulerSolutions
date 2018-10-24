// ProjectEulerSolutionsTest.cs
//
// Test file for all PE questions
// Copyright (c) 2018 Balint Gyevnar

﻿using System;

namespace ProjectEulerSolutions
{
    public sealed class ProjectEulerSolutionsTest
    {
        // Testing all solutions
        public static void Main(string[] args)
        {
            AssertEquals("233168", new S1().Run());
            AssertEquals("4613732", new S2().Run());

            Console.WriteLine("All tests ran succesfuly.");
            Console.ReadLine();
        }

        // Simple method to test equality
        public static void AssertEquals(object objA, object objB)
        {
            if (!objA.Equals(objB))
                throw new Exception("Assertion failed");
        }
    }
}
