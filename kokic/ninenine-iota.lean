open List def main:=println! iota 9|>foldl (λ x y=>x++foldl (λ s t=>s!"{s}{t}*{y}={t*y}\t") "" (iota y)++"\n") ""
