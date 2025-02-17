(*
    Grant DeWaay LeetCode F# Solutions
    Full Repo: https://github.com/GrantDeWaay/LeetCodeFSharpSolutions
    
    13. Roman to Integer
    Problem Link: https://leetcode.com/problems/roman-to-integer/
*)

let charToInteger char =
    match char with
    | 'I' -> 1
    | 'V' -> 5
    | 'X' -> 10
    | 'L' -> 50
    | 'C' -> 100
    | 'D' -> 500
    | 'M' -> 1000
    | _ -> 0

let romanToInteger (numerals: string) =
    let rec convert = function
        | [] -> 0
        | [x] -> x
        | x :: y :: rest when x <= y -> convert rest + x +  y
        | x :: y :: rest -> convert rest + x - y
        
    numerals |> Seq.map charToInteger |> Seq.toList |> List.rev |> convert

let romanNumeral = "CMXCIX"

printfn "The roman numeral \"%s\" represents the integer %d" romanNumeral (romanToInteger romanNumeral)