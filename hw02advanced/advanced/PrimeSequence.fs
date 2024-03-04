open System

let isPrime num =
    let ceil = float num |> sqrt |> ceil |> Convert.ToInt32
    let divisors = seq { 2..ceil } |> Seq.filter (fun x -> num % x = 0)
    Seq.length divisors = 0
    
let getPrimeSequence = 
    Seq.initInfinite (fun x -> x) |> Seq.filter isPrime

let primes10 = getPrimeSequence |> Seq.take 10
Seq.iter (printfn "%i") primes10