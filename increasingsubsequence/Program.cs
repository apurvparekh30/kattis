using System;
using System.Text;

namespace increasingsubsequence
{
    
    class Program
    {
        static int n;
        static int []arr,LIS,p;
        static void Main(string[] args)
        {
            while(true){
                string []tokens = Console.ReadLine().Split();
                n = int.Parse(tokens[0]);
                if(n==0)
                    break;
                arr = new int[n];
                LIS = new int[n];
                p = new int[n];
                int max = -1;
                for(int i=0;i<n;i++){
                    arr[i] = int.Parse(tokens[i+1]);
                    p[i] = i;
                    int idx = -1;
                    for(int j=0;j<i;j++){
                        if(arr[j] < arr[i]){
                            if(idx == -1 || LIS[j] > LIS[idx]){
                                idx = j;
                            }
                            else if(LIS[j] == LIS[idx]){
                                if(arr[j] < arr[idx]){
                                    idx = j;
                                }
                            }
                        }
                    }
                    if(idx != -1){
                        LIS[i] = LIS[idx] + 1;
                        p[i] = idx;
                    }
                    else{
                        LIS[i] = 1;
                    }
                    if(LIS[i] > max)
                        max = LIS[i];
                }
                int []ans = new int[max + 1];
                for(int i=0;i<=max;i++)
                    ans[i] = int.MaxValue;
                for(int i=0;i<n;i++){
                    
                    if(LIS[i] == max){
                        int []tmp = new int[max+1];
                        int j = i;
                        int idx = max;
                        while(p[j]!=j){
                            tmp[idx] = arr[j];
                            j = p[j];
                            idx--;
                        }
                        tmp[idx] = arr[j];
                        tmp[0] = max;
                        bool flag = false;
                        for(int k=1;k<=max;k++){
                            if(ans[k] < tmp[k] && !flag)
                                break;
                            if(flag || tmp[k] < ans[k]){
                                ans[k] = tmp[k];
                                flag = true;
                                ans[0] = tmp[0]; 
                            }
                        }
                    }
                }
                
                for(int i=0;i<=max;i++)
                    Console.Write(ans[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
