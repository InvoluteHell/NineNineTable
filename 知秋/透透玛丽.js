function a(b){f=1;c=b;while(c--)process.stdout.write(`${f}x${b}=${f++*b} ${c==0?'\n':''}`);if(b==9)return;a(++b)}a(1)