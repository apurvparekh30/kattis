using System;
using System.Text;
using System.Globalization;

namespace parsinghex
{
    class Program
    {
        static bool isHex(char c){
            if(char.IsDigit(c))
                return true;
            if(c>='a' && c<='f')
                return true;
            if(c>='A' && c<='F')
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            while(true){
                string line = Console.ReadLine();
                if(string.IsNullOrEmpty(line))
                    break;
                for(int i=1;i<line.Length;i++){
                    if((line[i]=='x' || line[i]=='X') && line[i-1]=='0'){
                        string hex = line.Substring(i-1);
                        int j = 2;
                        while(j < hex.Length && isHex(hex[j])){
                            j++;
                        }
                        hex = hex.Substring(0,j);
                        //Console.Write(hex+" ");
                        Console.WriteLine(hex+ " " + long.Parse(hex.Substring(2),NumberStyles.HexNumber));
                    }
                }
            }
        }
    }
}