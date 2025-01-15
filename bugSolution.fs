let swap x y = 
    (y, x)

let x, y = 10, 20
let y, x = swap x y
printf "%d %d" x y //This will print 20 10