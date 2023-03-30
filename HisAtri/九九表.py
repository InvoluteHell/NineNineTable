def c_add(num1, num2):
    str1 = str(num1)
    str2 = str(num2)
    
    num1_digits = [int(d) for d in str1]
    num2_digits = [int(d) for d in str2]
    
    result = []
    
    carry = 0
    
    while len(num1_digits) > 0 or len(num2_digits) > 0:
        if len(num1_digits) > 0:
            digit1 = num1_digits.pop()
        else:
            digit1 = 0
        if len(num2_digits) > 0:
            digit2 = num2_digits.pop()
        else:
            digit2 = 0
            
        digit_sum = digit1 + digit2 + carry
        
        if digit_sum >= 10:
            carry = 1
            digit_sum -= 10
        else:
            carry = 0
            
        result.insert(0, digit_sum)
    
    if carry == 1:
        result.insert(0, carry)
    
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
    pass

a = [1, 2, 3, 4, 5, 6, 7, 8, 9]
for i in a:
    j = 1
    while j <= i:
        print(f'{i}*{j}={c_multiply(i,j)}', end='\t')
        j = c_add(j,1)
    print()