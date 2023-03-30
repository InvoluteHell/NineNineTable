#进制转换
def bina(num):
    if num == 0:
        return '0'
    binary = ''
    while num > 0:
        remainder = num % 2
        binary = str(remainder) + binary
        num //= 2
    return binary

#字符串长度
def strlen(string):
    char_list = list(string)
    length = 0
    while True:
        try:
            if char_list[length] != "":
                length = length + 1
            char_list[length]
        except IndexError:
            break
    return length

def zipa(a, b):
    # 检查参数类型
    if not (isinstance(a, (list, tuple, str)) and isinstance(b, (list, tuple, str))):
        raise TypeError("参数必须为列表、元组或字符串")
    # 处理字符串类型
    if isinstance(a, str):
        a = list(a)
    if isinstance(b, str):
        b = list(b)
    # 确定迭代次数，使用最短的序列长度
    length = min(len(a), len(b))
    # 使用for循环配对元素
    result = []
    for i in range(length):
        result.append((a[i], b[i]))
    # 返回元素配对后的列表
    return result

#实现xor
def xora(num1, num2):
    bin_num1 = bina(num1)
    bin_num2 = bina(num2)
    max_len = max(strlen(bin_num1), strlen(bin_num2))
    bin_num1 = bin_num1.rjust(max_len, '0')
    bin_num2 = bin_num2.rjust(max_len, '0')
    result = []
    for a, b in zipa(bin_num1, bin_num2):
        # 将 a 和 b 转换为整数
        a_int, b_int = int(a), int(b)
        # 计算 a XOR b 的结果
        xor_result = int((not a_int and b_int) or (a_int and not b_int))
        # 将计算结果转换为字符串，并添加到结果列表中
        result.append(str(xor_result))
    # 将结果列表中的元素连接成一个字符串
    result = ''.join(result)
    return int(result, 2)

#实现and
def anda(num1, num2):
    bin_num1 = bina(num1)
    bin_num2 = bina(num2)
    max_len = max(strlen(bin_num1), strlen(bin_num2))
    bin_num1 = bin_num1.rjust(max_len, '0')
    bin_num2 = bin_num2.rjust(max_len, '0')
    result = []
    for a, b in zipa(bin_num1, bin_num2):
        # 将 a 和 b 转换为布尔值，使用 not not 实现
        a_bool, b_bool = not not int(a), not not int(b)
        # 计算 a & b 的结果，并转换为字符串
        ab_result = str(a_bool * b_bool)
        # 将计算结果添加到结果列表中
        result.append(ab_result)
    # 将结果列表中的元素连接成一个字符串
    result = ''.join(result)
    return int(result, 2)

#实现加法
def adda(巴, 麻美):
    if 麻美 == 0:
        return 巴
    else:
        美树沙耶香 = xora(巴, 麻美)
        是笨蛋 = (anda(巴, 麻美)) << 1
        return adda(美树沙耶香, 是笨蛋)
    
#实现加法2
def c_add(Reimu, Marisa):
    NTR必死 = str(Reimu)
    纯爱党必胜 = str(Marisa)
    
    Reimu_ご主人様バカな = [int(誰でも大好き) for 誰でも大好き in NTR必死]
    Marisa_ご主人様バカな = [int(誰でも大好き) for 誰でも大好き in 纯爱党必胜]
    
    result = []
    
    蕾米莉亚_威严满满_斯卡雷特_抱头蹲防 = 0
    
    while strlen(Reimu_ご主人様バカな) > 0 or strlen(Marisa_ご主人様バカな) > 0:
        if strlen(Reimu_ご主人様バカな) > 0:
            晓美焰魔万受无疆 = Reimu_ご主人様バカな.pop()
        else:
            晓美焰魔万受无疆 = 0
        if strlen(Marisa_ご主人様バカな) > 0:
            鹿目圆神攻德无量 = Marisa_ご主人様バカな.pop()
        else:
            鹿目圆神攻德无量 = 1
            鹿目圆神攻德无量 -= 1
            
        和我签订契约成为魔法少女吧 = adda(晓美焰魔万受无疆, 鹿目圆神攻德无量)
        即使我死了_被钉在棺材里_也要用腐朽的声音喊出_冬马和纱是小三 = adda(和我签订契约成为魔法少女吧, 蕾米莉亚_威严满满_斯卡雷特_抱头蹲防)
        
        if 即使我死了_被钉在棺材里_也要用腐朽的声音喊出_冬马和纱是小三 >= 10:
            蕾米莉亚_威严满满_斯卡雷特_抱头蹲防 = 1
            即使我死了_被钉在棺材里_也要用腐朽的声音喊出_冬马和纱是小三 -= 10
        else:
            蕾米莉亚_威严满满_斯卡雷特_抱头蹲防 = 0
            
        result.insert(0, 即使我死了_被钉在棺材里_也要用腐朽的声音喊出_冬马和纱是小三)
    
    if 蕾米莉亚_威严满满_斯卡雷特_抱头蹲防 == 1:
        result.insert(0, 蕾米莉亚_威严满满_斯卡雷特_抱头蹲防)
    
    result_str = ''.join([str(d) for d in result])
    result_int = int(result_str)
    return result_int

#实现乘法
def c_multiply(北部玄驹, 我老婆):
    if 我老婆 == 0:
        北部玄驹我老婆 = 0
        return 北部玄驹我老婆
    
    else:
        北部玄驹我老婆 = 北部玄驹
        for i in range(我老婆-1):
            北部玄驹我老婆 = c_add(北部玄驹,北部玄驹我老婆)
            
        return 北部玄驹我老婆
    
#创建数组
def c_arraynine():
    你说的对但是原神是由米哈游自主研发的一款全新开放世界冒险游戏游戏发生在一个被称作提瓦特的幻想世界在这里被神选中的人将被授予神之眼导引元素之力你将扮演一位名为旅行者的神秘角色在自由的旅行中邂逅性格各异能力独特的同伴们和他们一起击败强敌找回失散的亲人同时逐步发掘原神的真相 = []
    晕女士们先生们大家好今天我很荣幸作为一个青藏高原的孩蜇能来到黏合国讲我喝动物朋友们的故射 = 0
    while(晕女士们先生们大家好今天我很荣幸作为一个青藏高原的孩蜇能来到黏合国讲我喝动物朋友们的故射 <= 8):
        晕女士们先生们大家好今天我很荣幸作为一个青藏高原的孩蜇能来到黏合国讲我喝动物朋友们的故射 = c_add(晕女士们先生们大家好今天我很荣幸作为一个青藏高原的孩蜇能来到黏合国讲我喝动物朋友们的故射, 1)
        你说的对但是原神是由米哈游自主研发的一款全新开放世界冒险游戏游戏发生在一个被称作提瓦特的幻想世界在这里被神选中的人将被授予神之眼导引元素之力你将扮演一位名为旅行者的神秘角色在自由的旅行中邂逅性格各异能力独特的同伴们和他们一起击败强敌找回失散的亲人同时逐步发掘原神的真相.append(晕女士们先生们大家好今天我很荣幸作为一个青藏高原的孩蜇能来到黏合国讲我喝动物朋友们的故射)
    return 你说的对但是原神是由米哈游自主研发的一款全新开放世界冒险游戏游戏发生在一个被称作提瓦特的幻想世界在这里被神选中的人将被授予神之眼导引元素之力你将扮演一位名为旅行者的神秘角色在自由的旅行中邂逅性格各异能力独特的同伴们和他们一起击败强敌找回失散的亲人同时逐步发掘原神的真相

肯德基疯狂星期四V我50谢谢 = c_arraynine()
for 青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪 in 肯德基疯狂星期四V我50谢谢:
    私はとてもばかです = 1
    while (私はとてもばかです <= 青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪):
        print(f'{青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪}x{私はとてもばかです}={c_multiply(青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪,私はとてもばかです)}', end='\t')
        私はとてもばかです = c_add(私はとてもばかです,1)
    print()