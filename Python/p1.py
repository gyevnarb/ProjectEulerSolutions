# https://github.com/gyevnarb/ProjectEulerSolutions/tree/master/Python
# p1.py
#
# Solution for first Project Euler problem
# Copyright (c) 2018 Balint Gyevnar


def run():
    """
    Get answer to first Project Euler question
    Numbers are small, so a simple brute force solution suffices
    """

    return str(sum(x for x in range(1000) if x % 3 == 0 or x % 5 == 0))
