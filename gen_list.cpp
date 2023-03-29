#include <iostream>
#include <map>
#include <string>
#include <filesystem>

int main(int argc, char *argv[])
{
    // 获取当前运行程序的所在目录
    std::filesystem::path current_path = std::filesystem::current_path();
    // 获取目录下的所有子文件夹
    std::filesystem::directory_iterator dir_iter(current_path);
    std::map<std::string, int> user_size_map;
    for (auto &p : dir_iter)
    {
        if (p.is_directory())
        {
            std::cout << p.path().filename() << std::endl;
            auto key = p.path().filename().string();
            auto value = std::filesystem::file_size(p.path());
            user_size_map[key] = value;
        }
    }

    // 按照文件夹大小排序
    std::vector<std::pair<std::string, int>> user_size_vec;
    for (auto &p : user_size_map)
    {
        user_size_vec.push_back(p);
    }
    std::sort(user_size_vec.begin(), user_size_vec.end(), [](auto &a, auto &b)
              { return a.second > b.second; });

    // 打印排序结果
    int index = 1;
    for (auto &p : user_size_vec)
    {
        // | index |    user    |   size    |
        // |:-----:|:----------:|:---------:|
        // |   1   |  123456    |  123456   |
        std::cout << "| " << index << " | " << p.first << " | " << p.second << " |" << std::endl;
        index = index + 1;
    }
    return 0;
}