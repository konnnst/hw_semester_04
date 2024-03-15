module countEvensTest

open FsCheck
open FsUnit
open NUnit.Framework
open even

let checkEquality list =
    listCountEvenFilter list = listCountEvenFold list &&
    listCountEvenMap list = listCountEvenFold list &&
    listCountEvenFilter list = listCountEvenMap list

[<Test>]
let testCompareFunctions =
    Check.QuickThrowOnFailure checkEquality 

[<TestCase([| 1; 2; 3; 4 |], 2)>]
[<TestCase([||], 0)>]
[<TestCase( [| -6; -8; -2; -1|], 3)>]
[<TestCase([| 2; 4; -6; 8; 15 |], 4)>]
let testCountEvenFilter array expectedCount = 
    let list = array |> Array.toList
    listCountEvenFilter list |> should equal expectedCount

[<TestCase([| 1; 2; 3; 4 |], 2)>]
[<TestCase([||], 0)>]
[<TestCase( [| -6; -8; -2; -1|], 3)>]
[<TestCase([| 2; 4; -6; 8; 15 |], 4)>]
let testCountEvenMap array expectedCount = 
    let list = array |> Array.toList
    listCountEvenMap list |> should equal expectedCount

[<TestCase([| 1; 2; 3; 4 |], 2)>]
[<TestCase([||], 0)>]
[<TestCase( [| -6; -8; -2; -1|], 3)>]
[<TestCase([| 2; 4; -6; 8; 15 |], 4)>]
let testCountFold array expectedCount = 
    let list = array |> Array.toList
    listCountEvenFold list |> should equal expectedCount