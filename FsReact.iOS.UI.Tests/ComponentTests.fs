﻿module ComponentTests

open FsReact
open FsReact.UI

type CounterEvents = | ButtonClicked
type CounterState = { count: int }

let counter = 

    let getInitialState () = { count = 0 }

    let handleChange this (e, _) =
        let state = this.state
        match e with 
        | ButtonClicked -> { state with count = state.count+1 }

    let render this = 
        let state = this.state
        (*
        view [
            button "Click to Count" (this, ButtonClicked) [];
            text ("count: " + state.count.ToString()) [];
        ] []
        *)

        button "Click to count" (this, ButtonClicked) [];


    Core.createClass(getInitialState, handleChange, render);

