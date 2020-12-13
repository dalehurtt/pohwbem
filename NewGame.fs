module NewGame

open Terminal.Gui
open Terminal.Gui.Elmish

type State = {
    Name : string
}

type Msg =
    | Started

let init () = { Name = "" }, Cmd.none

let update msg state =
    match msg with
    | Started -> state, Cmd.none

let view state dispatch : View list =
    [
        label [
            Text "You are starting a new game"
        ]
    ]
    