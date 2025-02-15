(*
    Grant DeWaay F# LeetCode Solutions
    
    1. Two Sum
    Link: https://leetcode.com/problems/two-sum/
*)
let twoSum (input: int list) (target: int) =
    let rec findMatch nums seen index =
        match nums with
        | [] -> None
        | x :: xs ->
            let complement = target - x

            match Map.tryFind complement seen with
            | Some idx -> Some(idx, index) // Return the indexes of the pair
            | None -> findMatch xs (seen.Add(x, index)) (index + 1)

    findMatch input Map.empty 0

let i = [ 2; 7; 11; 15 ]
let target = 9

match twoSum i target with
| Some(idx1, idx2) -> printfn "Indexes found: %d, %d" idx1 idx2
| None -> printfn "No valid pair found"
