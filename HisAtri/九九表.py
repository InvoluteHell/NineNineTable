def c_add(Reimu, Marisa):
    NTR必死 = str(Reimu)
    纯爱党必胜 = str(Marisa)
    
    Reimu_ご主人様バカな = [int(誰でも大好き) for 誰でも大好き in NTR必死]
    Marisa_ご主人様バカな = [int(誰でも大好き) for 誰でも大好き in 纯爱党必胜]
    
    result = []
    
    蕾米莉亚_威严满满_斯卡雷特_抱头蹲防 = 0
    
    while len(Reimu_ご主人様バカな) > 0 or len(Marisa_ご主人様バカな) > 0:
        if len(Reimu_ご主人様バカな) > 0:
            晓美焰魔万受无疆 = Reimu_ご主人様バカな.pop()
        else:
            晓美焰魔万受无疆 = 0
        if len(Marisa_ご主人様バカな) > 0:
            鹿目圆神攻德无量 = Marisa_ご主人様バカな.pop()
        else:
            鹿目圆神攻德无量 = 1
            鹿目圆神攻德无量 -= 1
            
        即使我死了_被钉在棺材里_也要用腐朽的声音喊出_冬马和纱是小三 = 晓美焰魔万受无疆 + 鹿目圆神攻德无量 + 蕾米莉亚_威严满满_斯卡雷特_抱头蹲防
        
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

def c_multiply(北部玄驹, 我老婆):
    if 我老婆 == 0:
        北部玄驹我老婆 = 0
        return 北部玄驹我老婆
    
    else:
        北部玄驹我老婆 = 北部玄驹
        for i in range(我老婆-1):
            北部玄驹我老婆 = c_add(北部玄驹,北部玄驹我老婆)
            
        return 北部玄驹我老婆
    
def c_arraynine():
    玛丽 = []
    群rbq = 0
    while(群rbq <= 8):
        群rbq = c_add(群rbq, 1)
        玛丽.append(群rbq)
    return 玛丽

肯德基疯狂星期四V我50谢谢 = c_arraynine()
for 青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪 in 肯德基疯狂星期四V我50谢谢:
    私はとてもばかです = 1
    while 私はとてもばかです <= 青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪:
        print(f'{青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪}x{私はとてもばかです}={c_multiply(青春猪头大公鸡会不会摧毁兔女郎学姐小猫咪,私はとてもばかです)}', end='\t')
        私はとてもばかです = c_add(私はとてもばかです,1)
    print()