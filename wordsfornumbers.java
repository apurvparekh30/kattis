// https://open.kattis.com/problems/wordsfornumbers

import java.util.*;
import java.io.*;

class Solution {

    static FastReader fs = new FastReader();
    static String []digits = {"zero","one","two","three","four","five","six","seven","eight","nine"};
    static String []special = {"ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen",
                                "seventeen","eighteen","nineteen"};
    public static String[] tens = {"", "", "twenty", "thirty", "forty", 
                                "fifty", "sixty", "seventy", "eighty", "ninety"};

    public static void main(String[] args) {
        StringBuilder text = new StringBuilder();
        while(true){
            String line = fs.nextLine();
            if(line == null || line.isEmpty())
                break;
            StringTokenizer st = new StringTokenizer(line);
            boolean newLine = true;
            while(st.hasMoreTokens()){
                String token = st.nextToken();
                if(Character.isDigit(token.charAt(0))){
                    int number = Integer.parseInt(token);
                    StringBuilder sb = new StringBuilder();
                    if(number >= 20){
                        sb.append(tens[number/10]);
                        if(number%10 != 0){
                            sb.append('-');
                            sb.append(digits[number%10]);
                        }
                    }
                    else if(number >= 10){
                        sb.append(special[number%10]);
                    }
                    else
                        sb.append(digits[number]);
                    if(newLine){
                        sb.setCharAt(0, Character.toUpperCase(sb.charAt(0)));
                    }
                    token = sb.toString();
                }
                text.append(token).append(' ');
                newLine = false;
            }  
            text.append('\n');
        }
        System.out.print(text);
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