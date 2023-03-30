const fs = require('fs');
const path = require('path');

async function dirSize(dirPath) {
  let minSize = Number.MAX_SAFE_INTEGER;
  const files = await fs.promises.readdir(dirPath, { withFileTypes: true });
  const exts = ['.md', '.jpg', '.png', '.jpeg', '.log', '.gitignore', '.props', '.json'];
  const filteredFiles = files.filter(file => {
    const ext = path.extname(file.name);
    return !file.name.startsWith('.') && !exts.includes(ext);
  });
  const sizes = filteredFiles.map(async file => {
    const filePath = path.join(dirPath, file.name);
    const stats = await fs.promises.stat(filePath);
    if (stats.isDirectory()) {
      return await dirSize(filePath);
    }
    return stats.size;
  });
  return await Promise.all(sizes).then(sizes => {
    const minSizeInDir = Math.min(...sizes);
    return minSizeInDir === Number.MAX_SAFE_INTEGER ? 0 : minSizeInDir;
  });
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
    const minSize = await dirSize(dirPath);
    if (minSize === 0) {
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
