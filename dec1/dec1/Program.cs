
//nästa gång, dotnet new console

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{

    public static void Main(String[] args){
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        ReadFromFile rff = new ReadFromFile();
        List<List<int>> hej = rff.GetFromFileMethod();
        list1 = hej.ElementAt(0);
        list2 = hej.ElementAt(1);
        list1.Sort();
        list2.Sort();
        int sum = 0;
        for(int i = 0; i < list1.Count; i++)
        {

            int difference = Math.Abs(list1[i] - list2[i]);
            sum += difference;
        }
        Console.WriteLine("Part1 = " + sum);

        //Lista, index ska ha antal förekomster av numret. 
        //Tänkte fel.. oof

        Dictionary<int, int> dict = new Dictionary<int, int>();      

        foreach(int element in list2){
            dict[element] = dict.GetValueOrDefault(element, 0) + 1;
        }

        sum = 0;
        foreach(int i in list1)
        {
            sum += i * dict.GetValueOrDefault(i, 0);
        }

        Console.WriteLine(sum);


    }
}





