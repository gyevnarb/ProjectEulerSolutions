-- https://github.com/gyevnarb/ProjectEulerSolutions/tree/master/Haskell
-- h2.hs
--
-- Solution for second Project Euler problem
-- Copyright (c) 2018 Balint Gyevnar

{-# LANGUAGE OverloadedStrings #-}
import Text.Printf
import Control.Exception
import Formatting
import Formatting.Clock
import System.Clock

-- Calculate asnwer with top-down dynamic programming
fib :: Integer -> [Integer]
fib 1 = [1, 0]
fib n = (a + b) : x
  where x@(a:b:_) = fib (n - 1)

run :: Integer
run = sum [x | x <- fib 50, x < 4000000, x `mod` 2 == 0]

main :: IO ()
main = do
  start <- getTime Monotonic
  let answer = run
  end <- getTime Monotonic
  printf "Problem 2: %d - Elapsed time " answer
  fprint (timeSpecs % "\n") start end
