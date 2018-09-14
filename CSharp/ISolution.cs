//
// Common interface for Project Euler solutions
// Copyright (c) 2018 Balint Gyevnar

namespace PESolutions
{
    /// <summary>
    /// Provides common interface for solutions
    /// </summary>
    interface ISolution
    {
        /// <summary>
        /// Run the solution algorithm
        /// Answers might be too large to handle with regular numerical variables, hence string as return value.
        /// </summary>
        /// <returns>A string containing the result of the algorithm.</returns>
        string Run();
    }
}
