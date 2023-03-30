for i in $(seq 1 9);do for j in $(seq 1 $i);do printf "%d*%d=%-3d" $i $j $(($i*$j));done;echo;done
