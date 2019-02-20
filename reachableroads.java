// https://open.kattis.com/problems/reachableroads

import java.util.*;
import java.io.*;

class Solution {

    static FastReader fs = new FastReader();
    static int m,r;
    static ArrayList<Integer> []list;
    static boolean []visited;

    static void rec(int s){
        visited[s] = true;
        if(list[s]==null)
            return;
        for(int d:list[s]){
            if(visited[d])
                continue;
            rec(d);
        }
    }
    
    public static void main(String[] args) {
        int cases = fs.nextInt();
        while(cases -- > 0){
            m = fs.nextInt();
            list = new ArrayList[m];
            r = fs.nextInt();
            while(r-- > 0){
                int s,d;
                s = fs.nextInt();
                d = fs.nextInt();
                if(list[s]==null)
                    list[s] = new ArrayList<>();
                if(list[d]==null)
                    list[d] = new ArrayList<>();
                list[s].add(d);
                list[d].add(s);
            }
            visited = new boolean[m];
            int cc = 0;
            for(int i=0;i<m;i++){
                if(visited[i])
                    continue;
                cc++;
                rec(i);
            }
            System.out.println(cc - 1);
        }
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