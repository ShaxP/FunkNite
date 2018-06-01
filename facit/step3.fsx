open System

type Transaction = { Amount:decimal; Timestamp:DateTime }

let withdraw  amount transactions =
   transactions @ [{Amount=(-amount); Timestamp=DateTime.Now}]

let deposit amount transcations:Transaction list = 
    transcations @ [{Amount=amount; Timestamp=DateTime.Now}]

let balance transactions = 
    List.sumBy (fun elem -> elem.Amount) transactions
// Examples
let transactions = []

transactions |> deposit 30000.0m |> withdraw 200.0m |> deposit 250.0m |> withdraw 300.0m |> deposit 500.0m |> balance


// New concepts:
// - Records
// - List.sumBy
// - Lambda expressions
// - Modules and Namespaces (open System)
// - DateTime (Not sure if everyone is familiar with .net)


// Övningar:
// 1. Skapa typen Transaction med Amount och Timestamp
// 2. Skriv om deposit och withdraw så att de tar in en Transaction list
// 3. Skriv om balance så att den tar in en Transaction list (sumBy används)
// 4. Skriv några rader som testar din kod