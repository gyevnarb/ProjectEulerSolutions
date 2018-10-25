// https://projectbalint.com/en/page/project-euler-solutions/Java
// J2.java
//
// Solution for first Project Euler problem
// Copyright (c) 2018 Balint Gyevnar

/**
 * Solution class for second Project Euler problem
 * 
 * @author gyevn
 *
 */
public class J2 implements ISolution {
	/**
	 * Calculate Fibonacci numbers using bottom-up dynamic programming 
	 * Runtime stays linear with respect to length of fib array and is also bounded above by the cut-off value
	 */
	@Override
	public String run() {
		int[] fib = new int[50];
		java.util.Arrays.fill(fib, -1);
		fib[0] = 0;
		fib[1] = 1;
		int total = 0;
		
		for (int i = 0; i < fib.length; i++) {
            if (fib[i] < 0)
                fib[i] = fib[i - 1] + fib[i - 2];

            if (fib[i] > 4e6)
            	break;

            if (fib[i] % 2 == 0)
                total += fib[i];
				
		}
		
		return Integer.toString(total);
	}
	
	@Override
	public int problemNumber() {
		return 2;
	}
	
}
