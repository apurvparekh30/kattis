using System;
using System.Text;
using System.Collections.Generic;

namespace variablearithmetic
{
    class Program
    {
        static IDictionary<string,int> map = new Dictionary<string,int>();
        static void Main(string[] args)
        {   
            for(int i=0;i<=100;i++){
                map[i.ToString()] = i;
            }
            while(true){
                string next = Console.ReadLine();
                if(next.Equals("0"))
                    break;
                
                string[] tokens = next.Split();
                int i = 0;
                int val = 0;
                IList<string> list = new List<string>();
                bool flag = true;
                while(i < tokens.Length){
                    if(tokens[i]=="="){
                        map[tokens[i-1]] = map[tokens[i+1]];
                        flag = false;
                        break;
                    }
                    if(tokens[i].Equals("+")){
                        i++;
                        continue;
                    }
                    if(map.ContainsKey(tokens[i])){
                        val = val + map[tokens[i]];
                    }
                    else{
                        list.Add(tokens[i]);
                    }
                    i++;
                }
                if(flag){
                    StringBuilder sb = new StringBuilder();
                    if(val != 0){
                        sb.Append(val);
                    }
                    foreach(string t in list){
                        if(sb.Length == 0){
                            sb.Append(t);
                        }
                        else{
                            sb.Append(" + " + t);
                        }
                    }
                    Console.WriteLine(sb);
                }
            }
        }
    }
}
