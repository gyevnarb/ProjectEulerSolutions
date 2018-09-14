# https://projectbalint.com/en/page/project-euler-solutions/
#
# Test file for all Project Euler questions
# Copyright (c) 2018 Balint Gyevnar


import importlib

available_solutions = {
    1: "233168",
}

for k, v in available_solutions.items():
    module = importlib.import_module("p{}".format(k))
    answer = module.run()
    assert v == answer

print('Tests ran successfuly')
