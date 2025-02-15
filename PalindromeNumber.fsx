(*
    Grant DeWaay LeetCode F# Solutions
    Full Repo: https://github.com/GrantDeWaay/LeetCodeFSharpSolutions
    
    9. Palindrome Number
    Problem Link: https://leetcode.com/problems/palindrome-number/
*)

let palindromeNumber (x: int) =
    let rec flip (reverse: int) (curVal: int) =
        if curVal > 0 then flip (reverse*10 + curVal%10) (curVal/10)
        else
        reverse
    if x < 0 then false
    else flip 0 x = x

let value = 121
match palindromeNumber value with
    | true -> printf "Yes, %d is a palindrome" value
    | false -> printf "No, %d is not a palindrome" value