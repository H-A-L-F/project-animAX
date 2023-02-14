import { createElement } from "react";
import { reactApi } from "./Interop.fs.js";

export function Html_h1_C6540BC(children) {
    return createElement("h1", {
        children: reactApi.Children.toArray(Array.from(children)),
    });
}

