for i in {9..1};do for j in $(seq $i);do echo -n "$j*$i=$((i*j)) ";done;echo;done
