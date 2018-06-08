// New concepts:
// - Lists
// - List append
// - List.sum
// - List head, tail


// Övningar
// 1. Skriv om withdraw och deposit så att de tar en lista av transaktioner
let withdraw  amount transactions = (-amount) :: transactions
let deposit amount transcations = amount :: transcations
// 2. Skriv funktionen Balance som räknar ut saldot
let balance (transactions:int list) = List.sum transactions
// 3. Skriv en funktion som returnerar den senaste transaktionen
let latestTransaction transactions = 
    match transactions with
    | (head :: _) -> head
// 4. Skriv en funktion som returnerar den största deponeringen respektive den sörsta uttaget
let largestWithdrawal transactions = List.min transactions

let largestDisposition transactions = List.max transactions
// 5. Skriv en kodrad som utgår från balance på 3000, tar ut 200, deponerar 250, tar ut 300, deponerar 500 och returnerar saldot
[3000] |> withdraw 200 |> deposit 250 |> withdraw 300 |> deposit 500 |> balance

