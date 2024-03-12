module primeSequenceTest

open NUnit.Framework
open FsUnit
open prime


[<TestCase([||], 0)>]
[<TestCase([| 1; 2; 3 |], 3)>]
let sequenceCheck expectedArray count =
    let expected = Array.toSeq expectedArray
    let result = getPrimeSequence |> Seq.take count 
    result |> should equal expected