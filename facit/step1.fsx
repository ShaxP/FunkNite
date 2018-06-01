let withdraw  amount balance =
    balance - amount

let deposit  amount balance= 
    balance + amount


// Examples
//withdraw 500 balance
//deposit 600 balance
let balance = 30000

withdraw 200 balance

deposit 200 balance

withdraw 200 (deposit 200 balance)

balance |> withdraw 200 |> deposit 250 |> withdraw 300 |> deposit 500 

// New concepts:
// - Functions
// - Pipes


// Övningar
// 1. Skriv en funktion för deposit
// 2. Skriv en funktion för withdraw
// 3. Deklarera balance
// 4. Skriv en rad som deponerar 200
// 5. Skriv en rad som tar ut 200
// 6. Skriv en kodrad som lägger in 200 och tar ut 300
// 7. Skriv en kodrad som använder Pipe för 4, 5, 6