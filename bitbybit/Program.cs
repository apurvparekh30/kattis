using System;


namespace bitbybit
{
    class Program
    {
        static int n;
        static char AND(char bitI, char bitJ)
        {
            if (bitI == '0' || bitJ == '0')
            {
                return '0';
            }
            if (bitI == '?' || bitJ == '?')
            {
                return '?';
            }
            return '1';
        }

        static char OR(char bitI, char bitJ)
        {
            if (bitI == '1' || bitJ == '1')
            {
                return '1';
            }
            if (bitI == '?' || bitJ == '?')
            {
                return '?';
            }
            return '0';
        }
        static void Main(string[] args)
        {
            while(true){
                n = int.Parse(Console.ReadLine());
                if(n == 0)
                    break;
                char[] array = "????????????????????????????????".ToCharArray();
               
                while(n-- > 0){
                    string []tokens = Console.ReadLine().Split(' ');
                    if(tokens[0].Equals("SET")){
                        int i = int.Parse(tokens[1]);
                        array[i] = '1';
                    }
                    else if(tokens[0].Equals("CLEAR")){
                        int i = int.Parse(tokens[1]);
                        array[i] = '0';
                    }
                    else if(tokens[0].Equals("AND")){
                        int i = int.Parse(tokens[1]);
                        int j = int.Parse(tokens[2]);
                        /* if(array[i]=='?' || array[j]=='?'){
                            array[i] = '?';
                            continue;
                        }
                        if(array[i]=='1' && array[j]=='1'){
                            array[i] = '1';
                            continue;
                        }
                        array[i] = '0'; */
                        array[i] = AND(array[i],array[j]);

                    }
                    else if(tokens[0].Equals("OR")){
                        int i = int.Parse(tokens[1]);
                        int j = int.Parse(tokens[2]);
                        array[i] = OR(array[i],array[j]);
                    }
                }
                for(int i=31;i>=0;i--)
                    Console.Write(array[i]);
                Console.WriteLine();
            }
        }
    }
}
