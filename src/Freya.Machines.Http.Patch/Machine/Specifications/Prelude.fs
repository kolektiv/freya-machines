﻿namespace Freya.Machines.Http.Patch.Machine.Specifications

open Freya.Machines
open Hephaestus

(* Decision

    Construction functions for building Decisions, either with a basic
    approach, or a more opinionated approach of drawing a possible
    decision from the configuration (using a supplied lens). In the
    opionated case, if the decision is not found in configuration, a
    static decision will be created from the supplied default value. *)

[<RequireQualifiedAccess>]
module internal Decision =

    let create (key, name) decision =
        Specification.Decision.create
            (Key.add [ name ] key)
            (decision >> Decision.map)