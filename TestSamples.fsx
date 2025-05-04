#load "Utils.fs"
#load "Day1.fs"
#load "Day3.fs"
#load "Day7.fs"

open Utils

let expected11 = 11
evaluate Day1.solve1 "Samples\Sample1.txt" expected11 "Day1 puzzle 1"

let expected12 = 31
evaluate Day1.solve2 "Samples\Sample1.txt" expected12 "Day1 puzzle 2"

let expected31 = 2
evaluate Day3.solve1 "Samples\Sample3.txt" expected31 "Day3 puzzle 1"

let expected32 = 4
evaluate Day3.solve2 "Samples\Sample3.txt" expected32 "Day3 puzzle 2"

let expected71 = 3749
evaluate Day7.solve1 "Samples\Sample7.txt" expected71 "Day7 puzzle 1"

let expected72 = 11387
evaluate Day7.solve2 "Samples\Sample7.txt" expected72 "Day7 puzzle 2"