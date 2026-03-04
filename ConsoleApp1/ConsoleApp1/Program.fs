open System

//создание списка
let rec numberss(currentlist: int list) : int list = 
    let x = Console.ReadLine()
    if x = "ex" then
        currentlist
    else
        numberss(currentlist @[int(x)])

// Вычисление суммы цифр
let SumChislo n = 
    let rec loop curr summ =
        if curr = 0 then 
            summ
        else 
            loop (curr/10) (summ + (curr%10))
    loop n 0

let SumSpis num = 
    List.map SumChislo num // Приминение к каждому значению списка

[<EntryPoint>]
let main _ =
    printfn "Введите список через Enter"
    printfn "Для завершения ex"
    let res = numberss []

    let result = SumSpis res

    printfn "Исходный список: %A" res
    printfn "Список завершён %A" result

    0