#include <iostream>
#include <map>
#include <string>
#include <filesystem>

uintmax_t dir_size(const std::filesystem::path &path)
{
    uintmax_t size = 0;
    for (auto &p : std::filesystem::recursive_directory_iterator(path))
    {
        if (p.is_regular_file())
        {
            size += p.file_size();
        }
    }
    return size;
}

int main(int argc, char *argv[])
{
    // 获取当前运行程序的所在目录
    std::filesystem::path current_path = std::filesystem::current_path();
    // 获取目录下的所有子文件夹
    std::filesystem::directory_iterator dir_iter(current_path);
    std::map<std::string, int> user_size_map;
    for (auto &p : dir_iter)
    {
        // 忽略.开头的文件夹
        if (p.path().filename().string().find(".") == 0)
        {
            continue;
        }
        if (p.is_directory() == false)
        {
            continue;
        }
        
        auto key = p.path().filename().string();

        // 获取文件夹内所有文件的大小的最大值
        std::filesystem::directory_iterator dir_iter(p.path());
        int max_size = 0;
        int count = 0;
        for (auto &it : dir_iter)
        {
            // 忽略.开头的文件夹
            if (it.path().filename().string().find(".") == 0)
            {
                continue;
            }
            auto value = it.is_regular_file()?std::filesystem::file_size(it.path()):dir_size(it.path());
            if (value > max_size)
            {
                max_size = value;
            }
            count = count + 1;
        }
        if (count == 0)
        {
            continue;
        }

        auto value = max_size;
        user_size_map[key] = value;
    }

    // 按照文件夹大小排序
    std::vector<std::pair<std::string, int>> user_size_vec;
    for (auto &p : user_size_map)
    {
        user_size_vec.push_back(p);
    }
    std::sort(user_size_vec.begin(), user_size_vec.end(), [](auto &a, auto &b)
              { return a.second < b.second; });

    // 打印排序结果
    int index = 1;
    for (auto &p : user_size_vec)
    {
        // | index |    user    |   size    |
        // |:-----:|:----------:|:---------:|
        // |   1   |  123456    |  123456   |
        std::cout << "| " << index << " | " << p.first << " | " << p.second << " Bytes |" << std::endl;
        index = index + 1;
    }
    return 0;
}