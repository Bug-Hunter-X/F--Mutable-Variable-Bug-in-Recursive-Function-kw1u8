let x = ref 0
let y = ref 0

let rec loop i =
    if i > 10 then
        ()
    else
        x := !x + i; 
        y := !y + 1; 
        loop (i + 1)

loop 1
printf "%d %d" !x !y