using System;
using System.Collections.Generic;

namespace metaprogramming
{
    class Program
    {
        static IDictionary<string,int> map;
        static void Main(string[] args)
        {
            map = new Dictionary<string,int>();
            while(true){
                string line = Console.ReadLine();
                if(string.IsNullOrEmpty(line))
                    break;
                string []tokens = line.Split();
                if(tokens[0].Equals("define")){
                    map[tokens[2]] = int.Parse(tokens[1]);
                }
                else{
                    if(tokens[2].Equals("<")){
                        if(map.ContainsKey(tokens[1]) && map.ContainsKey(tokens[3])){
                            if(map[tokens[1]] < map[tokens[3]])
                                Console.WriteLine("true");
                            else
                                Console.WriteLine("false");
                        }
                        else{
                            Console.WriteLine("undefined");
                        }
                    }
                    else if(tokens[2].Equals(">")){
                        if(map.ContainsKey(tokens[1]) && map.ContainsKey(tokens[3])){
                            if(map[tokens[1]] > map[tokens[3]])
                                Console.WriteLine("true");
                            else
                                Console.WriteLine("false");
                        }
                        else{
                            Console.WriteLine("undefined");
                        }
                    }else{
                        if(map.ContainsKey(tokens[1]) && map.ContainsKey(tokens[3])){
                            if(map[tokens[1]] == map[tokens[3]])
                                Console.WriteLine("true");
                            else
                                Console.WriteLine("false");
                        }
                        else{
                            Console.WriteLine("undefined");
                        }
                    }
                }
            }
        }
    }
}
