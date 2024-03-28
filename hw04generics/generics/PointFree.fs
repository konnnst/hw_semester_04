module PointFree

let func0 x l =
    List.map (fun y -> y * x) l

let func1 x =
    List.map (fun y -> y * x)

let func2 x = 
    List.map (fun y -> (*) x y)

let func3 x =
    List.map ((*) x)

let func4 =
    List.map << (*)

printfn "%A" <| (func0 3 [1; 2])
printfn "%A" <| (func1 3 [1; 2])
printfn "%A" <| (func2 3 [1; 2])
printfn "%A" <| (func3 3 [1; 2])
printfn "%A" <| (func4 3 [1; 2])