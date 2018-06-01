let withdraw  amount transactions =
    transactions @ [-amount]

let deposit amount transcations = 
    transcations @ [amount]

let balance (transactions:int list) =
    List.sum transactions


// Examples
let transactions = [30000]
let newTransactions = transactions |> withdraw 200 |> deposit 250 |> withdraw 300 |> deposit 500 

transactions |> withdraw 200 |> deposit 250 |> withdraw 300 |> deposit 500 |> balance

// New concepts:
// - Lists
// - List append
// - List.sum
// - List head, tail


// Övningar
// 1. Skriv om withdraw och deposit så att de tar en lista av transaktioner
// 2. Skriv funktionen Balance som räknar ut saldot
// 3. Skriv en funktion som returnerar den första transaktionen
// 4. Skriv en funktion som returnerar den största deponeringen respektive den sörsta uttaget
// 5. Skriv en kodrad som utgår från balance på 3000, tar ut 200, deponerar 250, tar ut 300, deponerar 500 och returnerar saldot

