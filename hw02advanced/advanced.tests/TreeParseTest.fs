module treeParseTest

open NUnit.Framework
open FsUnit
open treeParse
open FsCheck

[<Test>]
let testTreeParse = 
    let cases = [
        Sum(Number(2), Number(4));
        Div(Mult(Number(5), Number(4)), Number(2));
        Diff(Number(30), Number(239))
    ]
    let expected = [ 6; 10; -209 ]
    let result = cases |> List.map eval
    result |> should equal expected

let checkArithmeticRules e1 e2 e3 = 
    Sum(Mult(e1, e3), Mult(e2, e3)) = Mult(Sum(e1, e2), e3) &&
    Mult(e1, Mult(e2, e3)) = Mult(Mult(e1, e2), e3) &&
    Diff(Mult(e2, e2), Mult(e1, e1)) = Mult(Diff(e2, e1), Sum(e2, e1))

let testAtithmeticRules = 
      Check.QuickThrowOnFailure checkArithmeticRules
