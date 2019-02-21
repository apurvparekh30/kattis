using System;

namespace _10kindsofpeople
{
    
    class Program
    {
        static int r,c;
        static char [][]grid;
        static int []parent,rank;
        static int n;
        static int si,sj,di,dj;
        static int Find(int i){
            return (parent[i] == i ? i:parent[i] = Find(parent[i]));
        }
        static void Main(string[] args)
        {
            String []tokens = Console.ReadLine().Split();
            r = int.Parse(tokens[0]);
            c = int.Parse(tokens[1]);
            grid = new char[r][];
            parent = new int[r * c];
            rank = new int[r * c];
            for(int i=0;i<r;i++){
                grid[i] = Console.ReadLine().ToCharArray();
                for(int j=0;j<c;j++){
                    parent[i * c + j] = i * c + j;
                    int v = i - 1;
                    if(v >= 0){
                        if(grid[v][j] == grid[i][j]){
                            int x = Find(v * c + j);
                            int y = Find(i * c + j);
                            if(rank[x] > rank[y]){
                                parent[y] = x;
                            }
                            else {
                                parent[x] = y;
                                if(rank[x] == rank[y])
                                    rank[y]++;
                            }
                        }
                    }
                    v = j - 1;
                    if(v >= 0){
                        if(grid[i][v] == grid[i][j]){
                            int x = Find(i * c + v);
                            int y = Find(i * c + j);
                            if(rank[x] > rank[y]){
                                parent[y] = x;
                            }
                            else {
                                parent[x] = y;
                                if(rank[x] == rank[y])
                                    rank[y]++;
                            }
                        }
                    }
                }
            }
            n = int.Parse(Console.ReadLine());
            while(n-- > 0){
                tokens = Console.ReadLine().Split();
                si = int.Parse(tokens[0]) - 1;
                sj = int.Parse(tokens[1]) - 1;
                di = int.Parse(tokens[2]) - 1;
                dj = int.Parse(tokens[3]) - 1;
                if(Find(si * c + sj) == Find(di * c + dj)){
                    Console.WriteLine(grid[si][sj]=='1' ? "decimal" : "binary");
                }
                else
                    Console.WriteLine("neither");
            }
        }
    }
}
