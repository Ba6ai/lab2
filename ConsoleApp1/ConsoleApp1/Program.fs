open System

let numbers = [12; 23; 34]

// Вычисление суммы цифр
let SumChislo n = 
    let rec loop tek ioth =
        if tek = 0 then ioth
        else loop (tek/10) (ioth + (tek%10))
    loop n 0


let SumSpis numbe = 
    List.map SumChislo numbe // Приминение к каждому значению списка

[<EntryPoint>]
let main _ =
    let result = SumSpis numbers

    printfn "Исходный список: %A" numbers
    printfn "Список завершён %A" result

    0