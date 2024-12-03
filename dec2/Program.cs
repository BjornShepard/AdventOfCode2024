

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Numerics;

ReadFromFile rff = new ReadFromFile();
List<List<int>> hej = rff.GetFromFileMethod();

int sum = 0;
foreach(var intList in hej)
{
    //part 2. Part 1 uses validate safety only instead of problem dampener.
    if(ProblemDampener(intList)){
        sum+=1;
    }
}

Console.WriteLine(sum);


bool ProblemDampener(List<int> intList)
{
    if(ValidateSafety(intList)){
        return true;
    }else{
        for(int i = 0; i < intList.Count; i++)
        {
            List<int> temp = new List<int>(intList);
            temp.RemoveAt(i);
            if(ValidateSafety(temp))
            {
                return true;
            }
            
        }
        return false;
    }
}

bool ValidateSafety(List<int> intList)
{
    Boolean acending = false;
    int first = intList[0];
    if(first < intList[1]){
        acending = true;
    }

    for(int i = 1; i < intList.Count; i++)
    {
        int second = intList[i]; 
        if(acending)
        {
            if(first >= second)
            {
                return false;
            } 
        }
        else if(!acending)
        {
            if(first <= second)
            {
                return false;
            }
        }
        if(Math.Abs(first - second) > 3){
            return false;
        }

        first = intList[i];
    }
    return true;
}