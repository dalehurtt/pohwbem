module ContinueGame

open Terminal.Gui
open Terminal.Gui.Elmish
open GameState

type State = GameState.State

type Msg =
    | Started

let init () = GameState.NotLoaded, Cmd.none

let update msg state =
    match msg with
    | Started -> state, Cmd.none

let view state dispatch : View list =
    [
        label [
            Text "You are continuing a game"
        ]
    ]
    