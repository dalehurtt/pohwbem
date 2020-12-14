module GameState

type GameSelection = {
    Map : int
    Scenario : int
}

type State = 
    | NotLoaded
    | GameSelected of GameSelection
