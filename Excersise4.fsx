open System.IO

let writeTransactionToFile transaction = File.AppendAllText("statement.txt", "some string")
let writeTransactionToConsole transaction = printfn "%s" "Something"



//Forstsätt där vi avslutade uppgift 3
//1. Bygg ut "transaction" funktionerna så att dom har loggningsfunktionalitet
//  - Försök experimentera med Higher-order functions, currying och partial application.