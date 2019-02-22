import java.util.*;
import java.io.*;

class Solution {
    static FastReader fs = new FastReader();
    static HashMap<String, Integer> hm = new HashMap<>();

    public static void main(String[] args) {
        for (int i = 0; i <= 100; i++)
            hm.put(new Integer(i).toString(), i);
        while (true) {
            String next = fs.nextLine();
            if (next.equals("0"))
                break;
            StringTokenizer st = new StringTokenizer(next);
            int val = 0;
            String prev = "";
            List<String> list = new ArrayList<>();
            boolean flag = true;
            while (st.hasMoreTokens()) {
                String token = st.nextToken();
                if (token.equals("=")) {
                    hm.put(prev, hm.get(st.nextToken()));
                    list.clear();
                    flag = false;
                    break;
                }
                if (token.equals("+"))
                    continue;
                if (hm.containsKey(token))
                    val += hm.get(token);
                else
                    list.add(token);
                prev = token;
            }
            if (flag) {
                StringBuilder sb = new StringBuilder();
                if (val != 0) {
                    sb.append(val);
                }
                for (String t : list) {
                    if (sb.length() == 0) {
                        sb.append(t);
                    } else {
                        sb.append(" + " + t);
                    }
                }
                if (sb.length() > 0)
                    System.out.println(sb);
            }
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