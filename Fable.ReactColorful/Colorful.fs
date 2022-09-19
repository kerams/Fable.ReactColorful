module Fable.ReactColorful

open Fable.Core.JsInterop
open Fable.React.ReactBindings

type Rgb =
    abstract r: int with get, set
    abstract g: int with get, set
    abstract b: int with get, set

type Rgba =
    abstract r: int with get, set
    abstract g: int with get, set
    abstract b: int with get, set
    abstract a: float with get, set

type Hsl =
    abstract h: int with get, set
    abstract s: int with get, set
    abstract l: int with get, set

type Hsla =
    abstract h: int with get, set
    abstract s: int with get, set
    abstract l: int with get, set
    abstract a: float with get, set

type Hsv =
    abstract h: int with get, set
    abstract s: int with get, set
    abstract v: int with get, set

type Hsva =
    abstract h: int with get, set
    abstract s: int with get, set
    abstract v: int with get, set
    abstract a: float with get, set

let inline rgb (r: int) (g: int) (b: int): Rgb = !!{| r = r; g = g; b = b |}
let inline rgba (r: int) (g: int) (b: int) (a: float): Rgba = !!{| r = r; g = g; b = b; a = a |}

let inline hsl (h: int) (s: int) (l: int): Hsl = !!{| h = h; s = s; l = l |}
let inline hsla (h: int) (s: int) (l: int) (a: float): Hsla = !!{| h = h; s = s; l = l; a = a |}

let inline hsv (h: int) (s: int) (v: int): Hsv = !!{| h = h; s = s; v = v |}
let inline hsva (h: int) (s: int) (v: int) (a: float): Hsva = !!{| h = h; s = s; v = v; a = a |}

let hexPicker (color: string) (onChange: string -> unit) = React.createElement (import "HexColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hexAlphaPicker (color: string) (onChange: string -> unit) = React.createElement (import "HexAlphaColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])

let rgbPicker (color: Rgb) (onChange: Rgb -> unit) = React.createElement (import "RgbColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let rgbaPicker (color: Rgba) (onChange: Rgba -> unit) = React.createElement (import "RgbaColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let rgbStringPicker (color: string) (onChange: string -> unit) = React.createElement (import "RgbStringColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let rgbaStringPicker (color: string) (onChange: string -> unit) = React.createElement (import "RgbaStringColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])

let hslPicker (color: Hsl) (onChange: Hsl -> unit) = React.createElement (import "HslColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hslaPicker (color: Hsla) (onChange: Hsla -> unit) = React.createElement (import "HslaColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hslStringPicker (color: string) (onChange: string -> unit) = React.createElement (import "HslStringColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hslaStringPicker (color: string) (onChange: string -> unit) = React.createElement (import "HslaStringColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])

let hsvPicker (color: Hsv) (onChange: Hsv -> unit) = React.createElement (import "HsvColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hsvaPicker (color: Hsva) (onChange: Hsva -> unit) = React.createElement (import "HsvaColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hsvStringPicker (color: string) (onChange: string -> unit) = React.createElement (import "HsvStringColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
let hsvaStringPicker (color: string) (onChange: string -> unit) = React.createElement (import "HsvaStringColorPicker" "react-colorful", {| color = color; onChange = onChange |}, [])
