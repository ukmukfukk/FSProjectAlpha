#load "Utils.fs"
#load "Day1.fs"
open Utils

let expected11 = 11
evaluate Day1.solve1 "Samples\Sample1.txt" expected11 "Day1 puzzle 1"

let expected12 = 31
evaluate Day1.solve2 "Samples\Sample1.txt" expected12 "Day1 puzzle 2"