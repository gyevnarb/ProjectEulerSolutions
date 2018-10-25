# https://projectbalint.com/en/page/project-euler-solutions/
#
# Test file for all Project Euler questions
# Copyright (c) 2018 Balint Gyevnar


import importlib
import time

available_solutions = {
    1: '233168',
    2: '4613732',
}

for k, v in available_solutions.items():
    module = importlib.import_module('p{}'.format(k))

    print('Problem {}: '.format(k), end='')

    start = time.time()
    answer = module.run()
    end = time.time() - start

    print('{0} - Elapsed time: {1:.8f}'.format(answer, end))

    assert v == answer

print('Tests ran successfuly')
