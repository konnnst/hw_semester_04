module simple.tests

open NUnit.Framework
open simple

[<TestCase(0, 1)>]
[<TestCase(1, 1)>]
[<TestCase(5, 120)>]
let TestFactorial n expected =
    Assert.AreEqual(expected, factorial n)

[<TestCase(1, 0)>]
[<TestCase(2, 1)>]
[<TestCase(9, 21)>]
[<TestCase(17, 987)>]
let TestFibonacci n expected =
    Assert.AreEqual(expected, fibonacci n)

[<TestCase([||], [||])>]
[<TestCase([|1; 4; 2; 4|], [|4; 2; 4; 1|])>]
[<TestCase([|1|], [|1|])>]
[<TestCase([|2; 4|], [|4; 2|])>]
let TestReverseList originalArray expectedArray  =
    let original = Array.toList originalArray
    let expected = Array.toList expectedArray
    Assert.AreEqual(expected, reverseList original)

[<TestCase(0, 4, [|1; 2; 4; 8; 16|])>]
[<TestCase(6, 6, [|64|])>]
[<TestCase(0, 0, [|1|])>]
let TestDegreeSeries n m expectedArray =
    let expected = Array.toList expectedArray
    Assert.AreEqual(expected, degreeSeries n m)

[<TestCase(4, [|1; 2; 3; 4|], 3)>]
[<TestCase(5, [|1; 2; 3; 4|], -1)>]
[<TestCase(1, [|1|], 0)>]
let TestFindNumber number array position =
    let list = Array.toList array
    Assert.AreEqual(position, findNumber list number)