using System;

namespace howmanydigits
{
    class Program
    {
        static int n;
        static double []arr = new double[1000001];
        static void Main(string[] args)
        {
            arr[2] = Math.Log10(2);
            for(int i=3;i<=1000000;i++)
                arr[i] = arr[i-1] + Math.Log10(i);
            while(true) {
                string next = Console.ReadLine();
                if(string.IsNullOrEmpty(next))
                    break;
                
                n = int.Parse(next);
                if(n==0 || n==1){
                    Console.WriteLine(1);
                    continue;
                }
                Console.WriteLine((int) arr[n] + 1);
            }
        }
    }
}
