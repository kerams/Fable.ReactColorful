# Fable.ReactColorful

Fable bindings for [react-colorful](https://github.com/omgovich/react-colorful) ([NPM package](https://npmjs.org/package/react-colorful)) version 5.6.0+.

## Nuget package
[![Nuget](https://img.shields.io/nuget/v/Fable.ReactColorful.svg?colorB=green)](https://www.nuget.org/packages/Fable.ReactColorful)

## Installation with [Femto](https://github.com/Zaid-Ajaj/Femto)

```
femto install Fable.ReactColorful
```

## Standard installation

Nuget package

```
paket add Fable.ReactColorful -p YourProject.fsproj
```

NPM package

```
npm install react-colorful@5.6.1
```

## Usage

Decide which of the [14 pickers/color models](https://github.com/omgovich/react-colorful#supported-color-models) you want to use and simply pass in the initial value and change callback. Helpers for constructing RGB(A), HSV(A) and HSL(A) values are included.

```fsharp
open Fable.React
open Fable.ReactColorful

let viewPickers () = div [] [
    hsvaStringPicker "hsva(295, 86%, 77%, 0.83)" (fun x -> Browser.Dom.console.log x)
    hslaPicker (hsla 20 20 20 0.5) (fun x -> Browser.Dom.console.log x)
    hexPicker "#ffa" (fun x -> Browser.Dom.console.log x)
]
```