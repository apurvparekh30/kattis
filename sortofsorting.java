import java.util.*;
import java.io.*;

class Solution {

    static FastReader fs = new FastReader();
    static int n;
    static String []strings;

    static class SortString implements Comparator<String>{
        @Override
        public int compare(String o1, String o2) {
            return o1.substring(0,2).compareTo(o2.substring(0,2));
        }
    }

    public static void main(String[] args) {
        while(true){
            n = fs.nextInt();
            if(n==0)
                break;
            strings = new String[n];
            for(int i=0;i<n;i++)
                strings[i] = fs.next();
            Arrays.sort(strings,new SortString());
            for(String s:strings)
                System.out.println(s);
            System.out.println();
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