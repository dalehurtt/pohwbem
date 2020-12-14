module NewGame

open Terminal.Gui
open Terminal.Gui.Elmish

open Scenarios
open GameState

type SelectionResult =
    | Predefined
    | Custom
    | None

let selectionItems = [
    (Predefined, "Pre-defined Scenario")
    (Custom, "Custom Scenario")
    (None, "Undecided")
]

type State = {
    Game : GameState.State
    Selection : SelectionResult
    Scenario : ScenarioResult
}

type Msg = 
    | NotSelected
    | ChangeSelection of SelectionResult
    | ChangeScenario of ScenarioResult


let init () = { Game = NotLoaded; Selection = None; Scenario = Undecided }, Cmd.none


let update msg state =
    match msg with
    | NotSelected -> state, Cmd.none

    | ChangeSelection selection -> { state with Selection = selection }, Cmd.none

    | ChangeScenario scenario -> { state with Scenario = scenario }, Cmd.none


let extras selection scenario dispatch = 
    listView [
        Styles [
            Pos (CenterPos, AbsPos 8)
        ]
        Value scenario
        Items scenarioList
        OnChanged (fun r -> dispatch (ChangeScenario r))
    ]


let view state dispatch : View list =
     [
        label [
            Text "You have two basic choices for a new game: select a pre-defined scenario; or design a custom scenario. Make your choice by selecting the appropriate radio button below."
            Styles [
                Pos (AbsPos 2, AbsPos 2)
                TextAlignment Centered
            ]
        ]
        radioGroup [
            Styles [
                Pos (CenterPos, AbsPos 4)
            ]
            Value state.Selection
            Items selectionItems
            OnChanged (fun r -> dispatch (ChangeSelection r))
        ]
        if state.Selection = Predefined then extras state.Selection state.Scenario dispatch
    ]
    