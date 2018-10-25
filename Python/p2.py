# https://github.com/gyevnarb/ProjectEulerSolutions/tree/master/Python
# p2.py
#
# Solution for second Project Euler problem
# Copyright (c) 2018 Balint Gyevnar


def run():
    """
    Get answer to second Project Euler question
    Use bottom-up dynamic programming to calculate Fibonacci numbers efficiently in linear time
    Code otherwise self-explanatory
    """

    fib = [0, 1]
    total = 0
    i = 2

    while True:
        fib.append(fib[i - 1] + fib[i - 2])
        if fib[i] > 4e6:
            break
        if fib[i] % 2 == 0:
            total = total + fib[i]
        i = i + 1

    return str(total)
