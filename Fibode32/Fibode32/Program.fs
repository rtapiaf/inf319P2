// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

let rec fibo n =
    match n with
    | 1 -> 0
    | 2 -> 1
    | 3 -> 1
    | n -> fibo (n-1) + fibo (n-2) + fibo (n-3)

let serie_fibo_recur n =
    for i in 1..n do
        printf "%d " (fibo i)
        
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine("Ingrese un numero: ")
    let n1 = Console.ReadLine()
    let n = Convert.ToInt32(n1)
    //let n = Console.ReadKey()
    //Console.WriteLine(fibo n)
    serie_fibo_recur n
    let tecla = Console.ReadKey()
    0 // devolver un código de salida entero
