
// https://open.kattis.com/problems/10kindsofpeople

import java.util.*;
import java.io.*;

class Solution {

    static FastReader fs = new FastReader();
    static int r, c;
    static char[][] grid;
    static int[] parent, rank;
    static int n;
    static int si, sj, di, dj;

    static int Find(int i){
        return (parent[i] == i ? i:(parent[i] = Find(parent[i])));
    }

    public static void main(String[] args) {
        r = fs.nextInt();
        c = fs.nextInt();
        grid = new char[r][];
        parent = new int[r * c];
        rank = new int[r * c];
        for (int i = 0; i < r; i++) {
            grid[i] = fs.next().toCharArray();
            for (int j = 0; j < c; j++) {
                parent[i * c + j] = i * c + j;
                int v = i - 1;
                if (v >= 0) {
                    if (grid[v][j] == grid[i][j]) {
                        int x = Find(v * c + j);
                        int y = Find(i * c + j);
                        if (rank[x] > rank[y]) {
                            parent[y] = x;
                        } else {
                            parent[x] = y;
                            if (rank[x] == rank[y])
                                rank[y]++;
                        }
                    }
                }
                v = j - 1;
                if (v >= 0) {
                    if (grid[i][v] == grid[i][j]) {
                        int x = Find(i * c + v);
                        int y = Find(i * c + j);
                        if (rank[x] > rank[y]) {
                            parent[y] = x;
                        } else {
                            parent[x] = y;
                            if (rank[x] == rank[y])
                                rank[y]++;
                        }
                    }
                }
            }
        }
        n = fs.nextInt();
        while (n-- > 0) {
            si = fs.nextInt() - 1;
            sj = fs.nextInt() - 1;
            di = fs.nextInt() - 1;
            dj = fs.nextInt() - 1;
            if (Find(si * c + sj) == Find(di * c + dj)) {
                System.out.println(grid[si][sj] == '1' ? "decimal" : "binary");
            } else
                System.out.println("neither");
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