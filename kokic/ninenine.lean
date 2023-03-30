open List #eval println! range 9|>map (·+1)|>foldl (λ x y=>x++foldl (λ s t=>s!"{s}{t}*{y}={t*y}\t") "" (range y|>map (·+1))++"\n") ""
