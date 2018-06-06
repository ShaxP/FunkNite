//#region The 'let' keyword
//let <identifier> = <value>

let a = 12
let b = 0.0 //64-bit a.k.a double
let c = 0.0m //decimal
let d = "Hello World!"
let e = "Hello" + "World"

let f = """{ "word1": "Hello",
             "word2": "World!"}"""

let g, h, i, j, k, l = a, b, c, d, e, f

let ``This is an identifier!`` = "Hello World!"
//#endregion

//#region Functions
(*
let <identifier> (<argument>: <type>) =
    <final expression>
*)

let redouble n1 = n1 + n1 
redouble 3

let bisect n1 = 
    n1 / 2


let square (n1: int) = n1 * n1

let isGreaterThan100 n1 : bool = n1 > 100

//Calls
let doubledValue = redouble 10

let bisectedValue = bisect doubledValue

let squaredValue = square bisectedValue

//#endregion

//#region The 'forward pipe' operator
10 |> redouble |> bisect |> square 

10 |> redouble |> bisect |> square 
   |> redouble |> bisect |> square
   |> redouble |> bisect |> square 
//#endregion


//#region Nested functions
let myFunction x =
    let redouble y =
        x + y
    redouble x

myFunction 10

//#endregion

//Exercise 1 Begins
-------------------

//#region List Preparation Exercise 2

//Onliner with semi-colon
let names = ["Jacob"; "Erik"; "Anna"; "Sandra"; "Peter"; "Osman"]

//Omitting semi-colon - Whitespace sensitive
let names = ["Jacob"
             "Erik" 
             "Anna"
             "Sandra"
             "Peter"
             "Osman"]


//Fast list initialization
let numbers = [1 .. 10]
let englishAlphabet = ['a' .. 'z']


//List – head::tail deconstruction
let numbers = [1 .. 10]

let head :: tail = numbers
let firstNum :: numbersWithoutFirstNum = numbers

//List append
let numbers = [1 .. 10]
let extendedNumbers = numbers @ [11 .. 20]


//List.sum
let numbers = [1 .. 10]

List.sum numbers


numbers |> List.sum

//#endregion

//#region Records - Preparation Exersice-3

//Declaration
type Person = { FirstName: string; LastName: string; Age: int; }

//Initialization - one-line
let somebody = { FirstName = "Marco"; LastName = "Polo"; Age = 33; }

//Initialization - Ommit semicolon - whitespace sensitive
let someboody = { 
    FirstName = "Marco"
    LastName = "Polo" 
    Age = 33 
    }
    
//Copy-update expression - the 'with' keyword
let newSomeboody = {
    someboody with Age = 34;
}

//#endregion


//#region - List.sumBy and lambda expressions
let somebody' = { 
    FirstName = "Marco"
    LastName = "Polo"
    Age = 33 
    }

let somebodyElse' = {
    FirstName = "John"
    LastName = "Doe"
    Age = 50
}

let persons = [somebody'; somebodyElse']

//without lambda
let persons = [somebody; somebodyElse]
let getAge person = person.Age

persons |> List.sumBy getAge


//with lambda expression
let persons = [somebody; somebodyElse]
persons |> List.sumBy (fun person -> person.Age)

//#endregion

//#region Unit and side-effects
()

printfn "Hello %s" "World!"

let myFunction x =
    ()
  
//#endregion


//#region Higher-order functions, currying and partial application - Preparation Exercise 4

//Without partial application - no plugin
type Address = { City: string; Zip: int; Street: string; }

let updateStreetAndLogToConsole street address =
    //Föreställ er valideringslogik här
    let updatedAddress = { address with Street = street } 
    writeAddressToConsole updatedAddress
    updatedAddress

let updateStreetAndLogToFile street address =
    //Föreställ er samma valideringslogik här
    let updatedAddress = { address with Street = street }
    writeAddressToFile updatedAddress
    updatedAddress

//With partial application - and plugin/Dependency injection  
 let updateStreetAndLog log street address =
    //Valideringslogik
    let updatedAddress = { address with Street = street }
    log updatedAddress
    updatedAddress

let updateStreetAndLogToConsole' = 
    updateStreetAndLog writeAddressToConsole

let updateStreetAndLogToFile' = 
    updateStreetAndLog writeAddressToFile


//#endregion


//#region Currying explained - Preparation Exercise 4
//Add example
let add n1 n2 = n1 + n2

let add'Explcit n1 =
    let partiallyAppliedFunc n2 =
        n1 + n2
    partiallyAppliedFunc

//Update street example
let updateStreetAndLog' log street address =
    //Valideringslogik
    let updatedAddress = { address with Street = street }
    log updatedAddress
    updatedAddress

let updateStreetAndLog'ExpliciyCurrying log =
    let streetFunc street =
        let addressFunc address =
            let updatedAddress  = { address with Street = street }
            log updatedAddress
            updatedAddress
        addressFunc
    streetFunc

//#endregion
