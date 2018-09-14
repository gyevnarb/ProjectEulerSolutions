using System;

namespace PESolutions
{
    public sealed class PESolutionsTest
    {
        // Testing all solutions
        public static void Main(string[] args)
        {
            AssertEquals("233168", new S001().Run());

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
