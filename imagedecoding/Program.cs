using System;
using System.Text;

namespace imagedecoding
{
    class Program
    {
        static char []ch = {'.','#'};
        static int n;
        static StringBuilder sb;
        static void Main(string[] args)
        {
            bool newLine = false;
            while(true){
                n = int.Parse(Console.ReadLine());
                if(n == 0)
                    break;
                int len = -1;
                bool flag = true;
                if(newLine)
                    Console.WriteLine();
                newLine = true;
                for(int i=0;i<n;i++){
                    sb = new StringBuilder();
                    string []tokens = Console.ReadLine().Split();
                    int k = 0;
                    if(tokens[0].Equals("#"))
                        k = 1;
                    for(int id=1;id<tokens.Length;id++){
                        int n = int.Parse(tokens[id]);
                        for(int j=0;j<n;j++){
                            sb.Append(ch[k]);
                        }
                        k = (k + 1) % 2;
                    }
                    Console.WriteLine(sb);
                    if(len == -1){
                        len = sb.Length;
                    }
                    else{
                        if(len != sb.Length)
                            flag = false;
                    }
                }
                if(!flag)
                    Console.WriteLine("Error decoding image");
            }
        }
    }
}
