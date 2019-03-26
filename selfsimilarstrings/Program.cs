using System;
using System.Collections.Generic;
namespace selfsimilarstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;

                int max = 0;
                bool flag = true;
                for (int size = 1; size < line.Length; size++)
                {
                    if(!flag)
                        break;
                    Dictionary<string, int> ht = new Dictionary<string, int>();
                    for (int start = 0; start < line.Length; start++)
                    {

                        if (start + size <= line.Length)
                        {
                            string sub = line.Substring(start, size);
                            if (ht.ContainsKey(sub))
                                ht[sub]++;
                            else
                                ht.Add(sub, 1);
                        }
                    }
                    foreach (string key in ht.Keys)
                    {
                        if (ht[key] <= 1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                        max = size;
                }


                Console.WriteLine(max);
            }
        }
    }
}