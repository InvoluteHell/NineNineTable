r=range
for b in r(10):print(*(f"{a}*{b}={a*b}\t"for a in r(1,b+1)))