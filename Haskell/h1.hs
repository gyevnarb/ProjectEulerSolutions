-- https://github.com/gyevnarb/ProjectEulerSolutions/tree/master/Haskell
-- h1.hs
--
-- Solution for first Project Euler problem
-- Copyright (c) 2018 Balint Gyevnar

-- Numbers remain small and problem stays tractable, so brute force is ideal in this case

{-# LANGUAGE OverloadedStrings #-}
import Text.Printf
import Control.Exception
import Formatting
import Formatting.Clock
import System.Clock

run :: Integer
run = sum [x | x <- [1..999], (x `mod` 3 == 0) || (x `mod` 5 == 0)]

main :: IO ()
main = do
  start <- getTime Monotonic
  let answer = run
  end <- getTime Monotonic
  printf "Problem 1: %d - Elapsed time " answer
  fprint (timeSpecs % "\n") start end
