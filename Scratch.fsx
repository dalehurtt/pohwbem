window [
            Styles [
                Dim (Fill, Fill)
            ]
            Title "Counter Demo"
        ][
            button [
                Styles [
                    Pos (CenterPos, AbsPos 2)
                ]
                Text "Counter U_p"
                OnClicked (fun () -> dispatch Increment)
            ]
            label [
                Styles [
                    Pos (CenterPos, AbsPos 4)
                    Dim (Fill, AbsDim 1)
                    TextAlignment Centered
                    Colors (Terminal.Gui.Color.Magenta, Terminal.Gui.Color.BrightYellow)
                ]
                Text (sprintf "Counter: %i" model.Counter)
            ]
            button [
                Styles [
                    Pos (CenterPos, AbsPos 6)
                ]
                Text "Counter D_own"
                OnClicked (fun () -> dispatch Decrement)
            ]
            button [
                Styles [
                    Pos (CenterPos, AbsPos 8)
                ]
                Text "R_eset Counter"
                OnClicked (fun () -> dispatch Reset)
            ]
        ]