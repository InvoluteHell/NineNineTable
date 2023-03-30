map(1:9) do x
    map(1:x) do y
        print("$x x $y = $(x*y)\t")
    end
    println()
end