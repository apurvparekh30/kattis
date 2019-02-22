using System;

namespace pathtracing
{
    class Program
    {
        static int mx=500,my=500;
        static int nx=500,ny=500;
        static void Main(string[] args)
        {
            int x=0,y=0;
            char [,]reg = new char[1001,1001];
            for(int i=0;i<1001;i++)
                for(int j=0;j<1001;j++)
                    reg[i,j] = ' ';
            
            reg[500,500] = 'S';
            x = 500;
            y = 500;

            while(true){
                string next = Console.ReadLine();
                if(string.IsNullOrEmpty(next)){
                    reg[x,y] = 'E';
                    break; 
                }
                if(next.Equals("left")){
                    y--;
                }
                else if(next.Equals("right")){
                    y++;
                }   
                else if(next.Equals("up")){
                    x--;
                }
                else{
                    x++;
                }
                if(reg[x,y]!='S')
                    reg[x,y] = '*';
                mx = Math.Min(mx,x);
                nx = Math.Max(nx,x);
                my = Math.Min(my,y);
                ny = Math.Max(ny,y);
            }
            //Console.WriteLine(ny + " " + my);
            int n = ny - my;
            int m = nx - mx;
            for(int i=0;i<=n+2;i++)
                Console.Write('#');
            Console.WriteLine();
            for(int i=mx;i<=nx;i++){
                Console.Write('#');
                for(int j=my;j<=ny;j++)
                    Console.Write(reg[i,j]);
                Console.Write('#');
                Console.WriteLine();
            }
            for(int i=0;i<=n+2;i++)
                Console.Write('#');
            Console.WriteLine();
        }
    }
}
