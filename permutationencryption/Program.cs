using System;

namespace permutationencryption
{
    
    class Program
    {
        static int n;
        static int []arr;
        static char []text;
        static void Main(string[] args)
        {
            while(true){
                string []tokens = Console.ReadLine().Split();
                n = int.Parse(tokens[0]);
                if(n==0)
                    break;
                arr=new int[n];
                for(int i=0;i<n;i++){
                    arr[i] = int.Parse(tokens[i+1]) - 1;
                }
                string temp = Console.ReadLine();
                while(temp.Length%n!=0)
                    temp += " ";
                text = temp.ToCharArray();
                char []excr = new char[text.Length];
                int id = 0;
                for(int i = 0;i < text.Length;i=i+n){

                    for(int k = 0;k < n; k++){
                        if(i + arr[k] >= text.Length)
                            continue;
                        excr[id++] = text[i + arr[k]];
                    }
                }
                Console.WriteLine("\'" + new string(excr)+"\'");
            }
        }
    }
}
