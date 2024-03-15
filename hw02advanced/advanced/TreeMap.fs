module treeMap

type Tree =
    | Node of int * Tree * Tree
    | Leaf of int

let rec treeMap map tree =
    match tree with
    | Node(value, left, right) -> Node(map value, treeMap map left, treeMap map right)
    | Leaf(value) -> Leaf(map value)


let tree = Node(5, Node(1, Leaf(3), Leaf(9)), Node(10, Leaf(3), Leaf(4)))
