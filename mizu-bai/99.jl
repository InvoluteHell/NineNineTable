map(1:9)do x map(1:x)do y "$y*$x=$(x*y) "end|>join|>println end
