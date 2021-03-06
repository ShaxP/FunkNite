open System

type Amount = decimal

type Timestamp = DateTime

type Transaction = 
    | Deposition of Amount * Timestamp
    | Withdrawal of Amount * Timestamp
// Övningar
// Givet typerna Amount, Timestamp och Transaction enligt ovan


// 1. Skriv om funktionerna withdraw och deposit
let withdraw  amount transactions =
   transactions @ [Withdrawal(amount, DateTime.Now)]

let deposit amount transcations:Transaction list = 
    transcations @ [Deposition(amount, DateTime.Now)]

// 2. Skriv om funktionen balance. Tips: använd List.sumBy med en funktion som tar en Transaction och returnerar dess belopp
let valueOf transaction =
    match transaction with
    | Deposition (amount, _) -> amount
    | Withdrawal (amount, _) -> (-amount)

let balance transactions = 
    List.sumBy (valueOf) transactions

// 3. Testa koden
let transactions = []

transactions |> deposit 30000.0m |> withdraw 200.0m |> deposit 250.0m |> withdraw 300.0m |> deposit 500.0m |> balance

// New concepts:
// - Tuples
// - Type abbreviations
// - Pattern matching
// - Discriminated unions

