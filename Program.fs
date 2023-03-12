open System

[<EntryPoint>]


let main argv =
    printfn "Hello World from F#!"
    printfn "Digite seu nome: "
    let mutable nome:string = Console.ReadLine()
    nome <- "Bem vindo meu amigo Felipe"
    printf "Seu nome é: %s\n" nome
  

    0