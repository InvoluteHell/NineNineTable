#include <stdio.h>
int main(){for(int i=1,j=1;i<10;){printf("%dx%d=%-4d",j,i,i*j);if(++j>i){++i;j=1;printf("\n");}}}