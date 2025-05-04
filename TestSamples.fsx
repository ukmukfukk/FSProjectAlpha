#load "Utils.fs"
#load "Day1.fs"
#load "Day3.fs"
open Utils

let expected11 = 11
evaluate Day1.solve1 "Samples\Sample1.txt" expected11 "Day1 puzzle 1"

let expected12 = 31
evaluate Day1.solve2 "Samples\Sample1.txt" expected12 "Day1 puzzle 2"

let expected21 = 2
evaluate Day3.solve1 "Samples\Sample3.txt" expected21 "Day3 puzzle 1"

let expected22 = 4
evaluate Day3.solve2 "Samples\Sample3.txt" expected22 "Day3 puzzle 2"
