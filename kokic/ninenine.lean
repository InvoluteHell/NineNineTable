open List def main := println! foldl (λ x y=>x++foldl (λ s t=>s!"{s}{t}*{y}={t*y}\t") "" (map (·+1) (range y))++"\n") "" (map (·+1) (range 9))
