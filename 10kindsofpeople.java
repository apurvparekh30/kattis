// https://open.kattis.com/problems/10kindsofpeople

import java.util.*;
import java.io.*;

class Solution{
    
    static FastReader fs = new FastReader();
    static int r,c;
    static int n;
    static char [][]grid;
    static int [][] color;
    static int dr[] = {1,0,-1,0};
    static int dc[] = {0,-1,0,1};
    static int si,sj,di,dj;
    
    static void rec(int i,int j,int nc){
        color[i][j] = nc;
        for(int k = 0;k < 4; k++){
            int ii = i + dr[k];
            int jj = j + dc[k];
            if(ii >= 0 && ii < r && jj >= 0 && jj < c && grid[i][j] == grid[ii][jj] && color[ii][jj] == 0){
                rec(ii,jj,nc);
            }
        }
    }
    
    public static void main(String[] args) {
        r = fs.nextInt();
        c = fs.nextInt();
        grid = new char[r][c];
        color = new int[r][c];

        for(int i=0;i<r;i++){
            String next = fs.next();
            grid[i] = next.toCharArray();
        }
        int nc = 2;
        for(int i=0;i<r;i++){
            for(int j=0;j<c;j++){
                if(color[i][j]==0){
                    rec(i,j,nc);
                    nc++;
                }
            }
        }
        n = fs.nextInt();
        
        StringBuilder sb = new StringBuilder();
        while(n-- > 0){
            si = fs.nextInt() - 1;
            sj = fs.nextInt() - 1;
            di = fs.nextInt() - 1;
            dj = fs.nextInt() - 1;
            if(color[si][sj] == color[di][dj])
                sb.append(grid[si][sj]=='1' ? "decimal" : "binary").append('\n');
            else
                sb.append("neither").append('\n');
        }
        System.out.print(sb);
    }
    static class FastReader {
        BufferedReader br;
        StringTokenizer st;
    
        public FastReader() {
            br = new BufferedReader(new InputStreamReader(System.in));
        }
    
        String next() {
            while (st == null || !st.hasMoreElements()) {
                try {
                    st = new StringTokenizer(br.readLine());
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
            return st.nextToken();
        }
    
        int nextInt() {
            return Integer.parseInt(next());
        }
    
        long nextLong() {
            return Long.parseLong(next());
        }
    
        double nextDouble() {
            return Double.parseDouble(next());
        }
    
        String nextLine() {
            String str = "";
            try {
                str = br.readLine();
            } catch (IOException e) {
                e.printStackTrace();
            }
            return str;
        }
    }
}