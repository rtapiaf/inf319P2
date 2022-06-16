fib::Int->Int->Int->Int->String
fib 0 a b c=""
fib n a b c=show a++ " "++fib (n-1) b c (a+b+c)

fibo::Int->String
fibo n= fib n 0 1 1

main::IO()
main = do
  putStrLn "Introduzca un numero"
  num1 <- getLine
  print (fibo (read num1))


