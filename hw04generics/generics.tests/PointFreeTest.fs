module generics.tests

open PointFree
open NUnit.Framework
open FsCheck


let checkEquality list multiplier = 
    func0 multiplier list = func1 multiplier list  && 
     func1 multiplier list = func2 multiplier list &&
     func2 multiplier list = func3 multiplier list


[<Test>]
let pfFscheckTest =
    Check.QuickThrowOnFailure checkEquality
