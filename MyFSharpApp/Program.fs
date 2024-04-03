type Coach = {
    Name: string
    FormerPlayer: bool
}

type Stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    Stats: Stats
}

let coaches = [
    {Name = "Steve Kerr"; FormerPlayer = true}
    {Name = "Erik Spoelstra"; FormerPlayer = false}
    {Name = "Billy Donovan"; FormerPlayer = false}
    {Name = "Rick Carlisle"; FormerPlayer = false}
    {Name = "J.B. Bickerstaff"; FormerPlayer = false}
]

let stats = [
    {Wins = 2923; Losses = 3098}
    {Wins = 1475; Losses = 1328}
    {Wins = 2344; Losses = 2254}
    {Wins = 1883; Losses = 1903}
    {Wins = 1984; Losses = 2287}
]

let teams = [
    {Name = "Golden State Warriors"; Coach = coaches.[0]; Stats = stats.[0]}
    {Name = "Miami Heat"; Coach = coaches.[1]; Stats = stats.[1]}
    {Name = "Chicago Bulls"; Coach = coaches.[2]; Stats = stats.[2]}
    {Name = "Indiana Pacers"; Coach = coaches.[3]; Stats = stats.[3]}
    {Name = "Cleveland Cavaliers"; Coach = coaches.[4]; Stats = stats.[4]}
]

let successfulTeams = teams |> List.filter (fun team -> team.Stats.Wins > team.Stats.Losses)

let successPercentages = successfulTeams |> List.map (fun team -> (team.Name, float team.Stats.Wins / float (team.Stats.Wins + team.Stats.Losses) * 100.0))

printfn "Successful teams:"
successPercentages |> List.iter (fun (team, percentage) -> printfn "%s: %f%%" team percentage)



type Cuisine =
    | Korean
    | Turkish

type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

type Activity =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int  


let fuelCostPerKilometer = 0.20 

let calculateBudget (activity : Activity) =
    match activity with
    | BoardGame -> 0.0
    | Chill -> 0.0
    | Movie movieType ->
        match movieType with
        | Regular -> 12.0
        | IMAX -> 17.0
        | DBOX -> 20.0
        | _ -> 12.0 + 5.0 
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive kilometers -> float kilometers * fuelCostPerKilometer


let movieNightRegular = Movie Regular
let movieNightIMAX = Movie IMAX
let movieNightDBOX = Movie DBOX
let movieNightWithSnacks = Movie RegularWithSnacks
let movie = Movie IMAXWithSnacks
let Dinner = Restaurant Korean
let dinnerAtTurkishRestaurant = Restaurant Turkish
let lastoption = LongDrive 70 

printfn "Budget for movie  (Regular): %.2f CAD" (calculateBudget movieNightRegular)
printfn "Budget for movie  (IMAX): %.2f CAD" (calculateBudget movieNightIMAX)
printfn "Budget for movie  (DBOX): %.2f CAD" (calculateBudget movieNightDBOX)
printfn "Budget for movie ( Regular with snacks): %.2f CAD" (calculateBudget movieNightWithSnacks)
printfn "Budget for movie (IMAXWithSnacks) : %.2f CAD" (calculateBudget movie)
printfn "Budget for dinner at Korean restaurent: %.2f CAD" (calculateBudget Dinner)
printfn "Budget for dinner at a Turkish restaurant: %.2f CAD" (calculateBudget dinnerAtTurkishRestaurant)
printfn "Budget for a long drive: %.2f CAD" (calculateBudget lastoption)






