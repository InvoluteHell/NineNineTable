#include <iostream>
int main()
{
    int i = 1, j = 1;
    for (; i < 10; i++) {
        for (j=1; j <= i; j++)
            printf("%d*%d=%d ", i, j, i * j);
        puts("");
    }
}

