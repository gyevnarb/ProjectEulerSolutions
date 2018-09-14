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

            Console.WriteLine("All tests ran succesfuly.");
        }

        // Simple method to test equality
        public static void AssertEquals(object objA, object objB)
        {
            if (!objA.Equals(objB))
                throw new Exception("Assertion failed");
        }
    }
}
