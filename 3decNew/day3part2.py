import numpy as np
from icecream import ic
import re

def main():
    #result should be 161
    input = open("c:/Users/starw/Desktop/Egna projekt/AdventOfCode2024/3decNew/input")
    inp = input.read()

    x = re.findall(r"mul\(\s*([0-9]+)\s*,([0-9]+)\)|(don't\(\))|(do\(\))", inp)
    ic(x)
    sum = 0
    modifier = True
    for each in x:
        if(each[2] =="don't()"):
            modifier = False
        if(each[3]=="do()"):
            modifier= True
        
        if(modifier and each[0] != ""):
            m = int(each[0]) * int(each[1])
            sum += m

    return sum

if __name__ == "__main__":
    print(main())