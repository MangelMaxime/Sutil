module TextInputs

open Sveltish
open Sveltish.Attr
open Sveltish.DOM

let name = Store.make("")

let view() =
    let nameOrStranger s = if s = "" then "stranger" else s

    Html.div [
        Html.input [
            type' "text"
            Bindings.bindAttr "value" name
            placeholder "Enter your name"
        ]
        Html.p [
            class' "block"
            Bindings.bind name (fun s -> text $"Hello {nameOrStranger s}")
        ]
    ]