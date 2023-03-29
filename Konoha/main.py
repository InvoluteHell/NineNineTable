for i in range(1, 10):
    k = ''
    for j in range(1,i+1):
        k+=str(j)+'x'+str(i)+'='+str(i*j)+'\t'
    print(k)