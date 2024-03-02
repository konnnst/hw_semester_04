let factorial n  =
    if n < 0 then (invalidArg "n" "Negative not expected")
    let rec factorialInner n acc =
        if n = 0 then acc else factorialInner (n - 1) (acc * n) 
    factorialInner n 1

let fibonacci n =
    if n < 0 then (invalidArg "n" "Negative not expected")
    let rec fibonacciInner n acc1 acc2 =
        if n = 1 then acc1 else fibonacciInner (n - 1) acc2 (acc1 + acc2)
    fibonacciInner n 0 1  


let reverseList list =
    let rec reverseListInner result pos =
        if pos = List.length list then result else reverseListInner (List.item pos list :: result) (pos + 1)
    reverseListInner [] 0

let degreeSeries n m =
    if n < 0 then invalidArg "n" "n should be positive"
    if n > m then invalidArg "n, m" "n should't be more than m"
    let rec degree2 degree acc =
        if degree = n then acc else degree2 (degree + 1) (acc * 2)
    let rec degreeSeriesInner list degree = 
        if degree < m 
            then degreeSeriesInner (2 * List.head list :: list) (degree + 1)
            else list
    reverseList (degreeSeriesInner [degree2 0 1] n)


let findNumber list number =
    let rec findNumberInner list pos =
        match list with
        | [] -> None
        | hd :: tl -> if hd = number then Some(pos) else findNumberInner tl (pos + 1)
    findNumberInner list 0

printfn "%A" (findNumber [ 1; 2; 3] 3)