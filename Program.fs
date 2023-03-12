open System


let buildMessage (name:string): string =
    if name.Length > 5 then
        "Olá, " + name + ". Seu nome é longo"
    else
        "Olá, " + name + ". Seu nome é curto."
    

[<EntryPoint>]

let main argv =
    printfn "Hello World from F#!"
    printfn "Digite seu nome: "
    let mutable nome:string = Console.ReadLine()
    printf "%s\n" (buildMessage nome)
    0