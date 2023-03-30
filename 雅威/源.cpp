#include<iostream>
#include<Windows.h>
#include<vector>
#include<math.h>
using namespace std;
int main(void) {
	int a = 1;
	int b = 1;
	int sum = 0;
	for (; a <= 9; a++) {
		for (; b <= a; b++) {
			sum = a * b;
			cout << a<<"*"<<b<<"="<<sum <<" ";
		}
		b = 1;
		cout << endl;
	}
	return 0;
}
