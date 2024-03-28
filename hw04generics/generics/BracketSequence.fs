module bracket

let isCorrectBracketSequence (string: string) =
    let rec popPairs bracketStack =
        if List.length bracketStack < 2 then bracketStack else
        let tail = List.tail (List.tail bracketStack)
        match (List.head bracketStack, List.item 1 bracketStack) with    
        | (')', '(') -> popPairs tail 
        | ('}', '{') -> popPairs tail 
        | (']', '[') -> popPairs tail 
        | _ -> bracketStack 
    let rec isCBSInner list pos=
        if String.length string = 0 then true else
        let newList = popPairs (string[pos] :: list)
        if pos = String.length string - 1 
            then List.length newList = 0 
            else isCBSInner newList (pos + 1)
    isCBSInner [] 0

printfn "%A" <| isCorrectBracketSequence ""