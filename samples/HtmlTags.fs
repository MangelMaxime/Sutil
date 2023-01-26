module HtmlTags

// Adapted from
// https://svelte.dev/examples

open Sutil
open Sutil.Core
open Sutil.CoreElements

let stringOfHtml = "here's some <strong>HTML!!!</strong>"

let view() = Html.p [
    html stringOfHtml
]
view() |> Program.mountElement "sutil-app"
