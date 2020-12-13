module Start

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

let view : View list =
    [
        label [
            Styles [
                Pos (CenterPos, AbsPos 1)
                Dim (Fill, AbsDim 1)
                TextAlignment Centered
            ]
            Text "Welcome to Play One-Hour Wargames By EMail (POHWBEM)."
        ]
    ]
    