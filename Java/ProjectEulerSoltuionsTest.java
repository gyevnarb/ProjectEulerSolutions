// https://projectbalint.com/en/page/project-euler-solutions/
// ProjectEulerSolutionsTest.java
//
// Project Euler Java test file
// Copyright (c) 2018 Balint Gyevnar

import static org.junit.Assert.*;

import org.junit.Test;

public class ProjectEulerSoltuionsTest {

	public static void runTest(ISolution problem, String expected) {
		long start = System.currentTimeMillis();
		String result = problem.run();
		long end = System.currentTimeMillis();
		assertEquals(expected, result);
		System.out.println("Problem " + problem.problemNumber() + ": " + result + " - Elapsed time: " + (end - start));
	}
	
	@Test
	public void testPE1() {
		runTest(new J1(), "233168");
	}

	@Test
	public void testPE2() {
		runTest(new J2(), "4613732");
	}
}
