#load "Utils.fs"
#load "Day1.fs"
#load "Day2.fs"
#load "Day7.fs"

open Utils

let expected11 = 11
evaluate Day1.solve1 "Samples\Sample1.txt" expected11 "Day1 puzzle 1"

let expected12 = 31
evaluate Day1.solve2 "Samples\Sample1.txt" expected12 "Day1 puzzle 2"

let expected21 = 2
evaluate Day2.solve1 "Samples\Sample2.txt" expected21 "Day2 puzzle 1"

let expected22 = 4
evaluate Day2.solve2 "Samples\Sample2.txt" expected22 "Day2 puzzle 2"

let expected71 = 3749
evaluate Day7.solve1 "Samples\Sample7.txt" expected71 "Day7 puzzle 1"

let expected72 = 11387
evaluate Day7.solve2 "Samples\Sample7.txt" expected72 "Day7 puzzle 2"