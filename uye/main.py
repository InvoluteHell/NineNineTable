for i in range(1, 10):
 print(*["%d*%d=%-2d"%(j,i,i*j)for j in range(1,i+1)])
