module treeParse

type Expression =
    | Sum of Expression * Expression
    | Diff of Expression * Expression
    | Mult of Expression * Expression
    | Div of Expression * Expression
    | Number of int
let rec eval expr = 
    try
        match expr with
        | Sum(e1, e2) -> eval e1 + eval e2
        | Diff(e1, e2) -> eval e1 - eval e2
        | Mult(e1, e2) -> eval e1 * eval e2
        | Div(e1, e2) -> eval e1 / eval e2
        | Number(n) -> n
    with
        | :? System.DivideByZeroException -> 
            printfn "Achtung! zero division detected! Emergency removal of operating system started!!1"; -1

