-- https://projectbalint.com/en/page/project-euler-solutions/#problems
--
-- Solution for first Project Euler problem
-- Copyright (c) 2018 Balint Gyevnar

-- Numbers remain small and problem stays tractable, so brute force is ideal in this case
run :: Integer
run = sum [x | x <- [1..999], (x `mod` 3 == 0) || (x `mod` 5 == 0)]

main :: IO ()
main = print run
