let listCountEvenMap list =
    list |> List.map (fun x -> (x + 1) % 2) |> List.sum

let listCountEvenFilter list =
    list |> List.filter (fun x -> x % 2 = 0) |> List.length

let listCountEvenFold list =
    list |> List.fold (fun acc x -> acc + (x + 1) % 2) 0

let list = [ 1; 2; 3; 4; 5 ]
printfn "%A" <| listCountEvenMap list
printfn "%A" <| listCountEvenFilter list
printfn "%A" <| listCountEvenFold list
