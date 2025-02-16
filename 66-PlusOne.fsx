(*
    Grant DeWaay LeetCode F# Solutions
    Full Repo: https://github.com/GrantDeWaay/LeetCodeFSharpSolutions
    
    66. Plus One
    Problem Link: https://leetcode.com/problems/plus-one/
*)

let plusOne digits =
    let rec addOne = function
        | [] -> [1]
        | 9 :: rest -> 0 :: addOne rest
        | x :: rest -> x + 1 :: rest
    digits |> List.rev |> addOne |> List.rev    

let inputValues = [3; 4; 1]

printfn "%A" (plusOne inputValues)