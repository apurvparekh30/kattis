using System;
using System.Text;

namespace almostperfect
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if(string.IsNullOrEmpty(line))
                    break;
                n = int.Parse(line);
                int sum = 1;
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                        int j = n / i;
                        if (i != j)
                        {
                            sum += j;
                        }
                    }
                }
                int diff = Math.Abs(sum - n);
                StringBuilder sb = new StringBuilder(n.ToString()).Append(' ');
                if (diff == 0)
                {
                    sb.Append("perfect");
                }
                else if (diff <= 2)
                {
                    sb.Append("almost perfect");
                }
                else
                {
                    sb.Append("not perfect");
                }
                Console.WriteLine(sb);
            }
        }
    }
}
