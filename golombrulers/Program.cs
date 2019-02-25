using System;
using System.Collections.Generic;
using System.Collections;

namespace golombrulers
{
    class Program
    {
        static List<int> list;
        
        static void Main(string[] args)
        {
            while(true){
                string line = Console.ReadLine();
                if(string.IsNullOrEmpty(line))
                    break;
                string[] tokens = line.Split(' ');
                int max = -1;
                list = new List<int>();
                foreach(string token in tokens){
                    int number = int.Parse(token);
                    list.Add(number);
                    if(max < number)
                        max = number;
                }
                list.Sort();
                bool []arr = new bool[max+1];
                bool ruler = true;
                for(int i=0;i<list.Count && ruler;i++){
                    for(int j=i+1;j<list.Count;j++){
                        int diff = Math.Abs(list[i] - list[j]);
                        if(arr[diff]){
                            ruler = false;
                            break;
                        }
                        arr[diff] = true;
                    }
                }
                if(ruler){
                    List<int> missing = new List<int>();
                    for(int i=1;i<max;i++){
                        if(!arr[i]){
                            missing.Add(i);
                        }
                    }
                    if(missing.Count == 0){
                        Console.WriteLine("perfect");
                    }
                    else {
                        Console.Write("missing");
                        foreach (int ele in missing){
                            Console.Write(" "+ele);
                        }
                        Console.WriteLine();
                    }
                }   
                else{
                    Console.WriteLine("not a ruler");
                }
            }
        }
    }
}
