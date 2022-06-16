namespace Library1
module fibonacci = 
  let serie_fibo_estruc n =
    let mutable a = 0
    let mutable b = 1
    let mutable c = 1
    for i in 1..n do
        if i = 1 then printf "%d " a
        elif i = 2 then printf "%d " b
        elif i = 3 then printf "%d " c
        else
        let sum = a + b + c 
        printf "%d " sum
        a <- b
        b <- c
        c <- sum
  let rec fibo n =
    match n with
    | 1 -> 0
    | 2 -> 1
    | 3 -> 1
    | n -> fibo (n-1) + fibo (n-2) + fibo (n-3)

  let serie_fibo_recur n =
    for i in 1..n do
        printf "%d " (fibo i)

type Class1() = 
    member this.X = "F#"
