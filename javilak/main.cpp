#include <iostream>
using namespace std;void cx(int a,int b){int c;c=a*b;cout << a <<"*"<<b<<"="<<c<<"\t";}int main() {for(int i=1;i<=9;i++){for (int j = 1; j <= i; ++j) {cx(i,j);}cout<<"\n";}}
