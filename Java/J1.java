// https://projectbalint.com/en/page/project-euler-solutions/Java
// J1.java
//
// Solution for first Project Euler problem
// Copyright (c) 2018 Balint Gyevnar

/**
 * Solution to first question on Project Euler
 * 
 * @author Balint Gyevnar
 *
 */
public class J1 implements ISolution {
	/**
	 * Numbers are small and bounded, brute force solution suffices
	 */
	@Override
	public String run() {
		int ans = 0;
		
		for (int i = 0; i < 1000; i++) {
			if (i % 3 == 0 || i % 5 == 0)
				ans += i;
		}
		
		return Integer.toString(ans);
	}

	@Override
	public int problemNumber() {
		return 1;
	}
	
}
