const fs = require('fs');
const path = require('path');

async function dirSize(dirPath) {
  let minSize = Number.MAX_SAFE_INTEGER;
  const files = await fs.promises.readdir(dirPath, { withFileTypes: true });
  for (const file of files) {
    const filePath = path.join(dirPath, file.name);
    const stats = await fs.promises.stat(filePath);
    if (stats.isFile() && path.extname(filePath) !== '.md') {
      if (stats.size < minSize) {
        minSize = stats.size;
      }
    }
  }
  return minSize;
}

async function main() {
  const currentPath = process.cwd();
  const dirs = await fs.promises.readdir(currentPath, { withFileTypes: true });
  const userSizeMap = new Map();
  for (const dir of dirs) {
    if (dir.name.startsWith('.') || !dir.isDirectory()) {
      continue;
    }
    const key = dir.name;
    const dirPath = path.join(currentPath, key);
    const files = await fs.promises.readdir(dirPath, { withFileTypes: true });
    let minSize = Number.MAX_SAFE_INTEGER;
    let count = 0;
    for (const file of files) {
      if (file.name.startsWith('.')) {
        continue;
      }
      const filePath = path.join(dirPath, file.name);
      const stats = await fs.promises.stat(filePath);
      const value = stats.isFile() ? stats.size : await dirSize(filePath);
      if (value < minSize) {
        minSize = value;
      }
      count++;
    }
    if (count === 0) {
      continue;
    }
    userSizeMap.set(key, minSize);
  }
  const userSizeVec = Array.from(userSizeMap.entries()).sort((a, b) => a[1] - b[1]);
  console.log('| index |    user    |   size    |');
  console.log('|:-----:|:----------:|:---------:|');
  userSizeVec.forEach(([user, size], index) => {
    console.log(`\| ${index + 1} | ${user} | ${size} Bytes |`);
  });
  
}

main();
