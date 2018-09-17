// https://projectbalint.com/en/page/project-euler-solutions/
//
// Project Euler Java test file
// Copyright (c) 2018 Balint Gyevnar

import static org.junit.Assert.*;

import org.junit.Test;

public class ProjectEulerSoltuionsTest {

	@Test
	public void testPE1() {
		String result = new J1().run();
		assertEquals("233168", result);
	}

}
