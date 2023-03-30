map(1:9)do x map(1:x)do y "$y*$x=$(x*y)\t"end|>join|>println end
