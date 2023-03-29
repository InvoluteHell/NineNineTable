seq 9|xargs -I_ seq -f'%g*_' _|bc -iq|xargs -n2|sed -zr 's/\n([^1])/\t\1/g'|tr \  =
