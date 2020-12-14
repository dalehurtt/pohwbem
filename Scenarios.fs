module Scenarios

type ScenarioResult =
    | Undecided
    | S1
    | S2
    | S3

let scenarioList = [
    (Undecided, "Undecided")
    (S1, "Scenario 1")
    (S2, "Scenario 2")
    (S3, "Scenario 3")
]
