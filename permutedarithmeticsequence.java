// https://open.kattis.com/problems/permutedarithmeticsequence

import java.util.*;
import java.io.*;

class Solution {

    static FastReader fs = new FastReader();
    static int m;
    static int[] copy;

    static boolean arithmetic() {
        int diff = copy[1] - copy[0];
        for (int i = 2; i < copy.length; i++) {
            if (copy[i] - copy[i - 1] != diff) {
                return false;
            }
        }
        return true;
    }

    static boolean permuted(){
        Arrays.sort(copy);
        return arithmetic();
    }

    public static void main(String[] args) {
        int cases = fs.nextInt();
        for (int tt = 1; tt <= cases; tt++) {
            m = fs.nextInt();
            copy = new int[m];
            for (int i = 0; i < m; i++)
                copy[i] = fs.nextInt();
            System.out.println(arithmetic() ?  "arithmetic": ( permuted() ? "permuted arithmetic":"non-arithmetic"));

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