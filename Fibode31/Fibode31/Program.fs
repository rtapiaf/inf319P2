// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

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
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("Ingrese un numero: ")
    let n1 = Console.ReadLine()
    let n = Convert.ToInt32(n1)
    //let n = Console.ReadKey()
    serie_fibo_estruc n
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
