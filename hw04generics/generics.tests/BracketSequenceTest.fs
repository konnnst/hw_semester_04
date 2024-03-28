open bracket
open NUnit.Framework
open FsUnit

[<Test>]
[<TestCase("",  true)>]
[<TestCase("[(])", false)>]
[<TestCase("([{}])()", true)>]
[<TestCase("([]){[]}({})", true)>]
[<TestCase(")", false)>]
[<TestCase("[])", false)>]
[<TestCase("}}[(}", false)>]
let bracketSequenceTest sequence isCorrect =
    (isCorrectBracketSequence sequence) |> should   equal isCorrect
   