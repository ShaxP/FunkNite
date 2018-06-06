open System

type Amount = decimal

type Timestamp = DateTime

type Transaction = 
    | Deposition of Amount * Timestamp
    | Withdrawal of Amount * Timestamp

// Övningar
// Givet typerna Amount, Timestamp och Transaction enligt ovan
// 1. Skriv om funktionerna withdraw och deposit
// 2. Skriv om funktionen balance. Tips: använd List.sumBy med en funktion som tar en Transaction och returnerar dess belopp
// 3. Testa koden