for i=1:1:9
    p="";
    for j=1:1:i
        p=p+i+"x"+j+"="+i*j+"\t";
    end
    fprintf(p+"\n")
end