using System;
using System.Collections.Generic;

namespace raceday
{
    class Program
    {
        class user:IComparable <user> {
            string first,last,bib,s1,s2,finish;
            int r1,r2,r3;
            public string First {
                get { return first; }
                set { first = value; }
            }
            public string Last {
                get { return last; }
                set { last = value; }
            }

            public string Bib {
                get { return bib; }
                set { bib = value; }
            }
            public string S1{
                get { return s1; }
                set { s1 = value; }
            }

            public string S2 {
                get { return s2; }
                set { s2 = value; }
            }

            public string Finish {
                get { return finish; }
                set { finish = value; } 
            }

            public int R1 {
                get { return r1; }
                set { r1 = value; }
            }

            public int R2 {
                get { return r2; }
                set { r2 = value; }
            }
            public int R3 {
                get { return r3; }
                set { r3 = value; }
            }        
            public int CompareTo(user other){
                return last.CompareTo(other.last);
            }    
        }
        static void Main(string[] args)
        {
            while(true){
                int n = int.Parse(Console.ReadLine());
                if(n==0)
                    break;
                Dictionary<string,int> ht = new Dictionary<string,int>();
                string []s1,s2,f;
                user []us = new user[n];
                for(int i=0;i<n;i++){
                    us[i] = new user();
                    string line = Console.ReadLine();
                    string []tokens = line.Split();
                    us[i].First = tokens[0];
                    us[i].Last = tokens[1];
                    us[i].Bib = tokens[2];
                    ht[us[i].Bib] = i;
                }
                s1 = new string[n];
                s2 = new string[n];
                f = new string[n];
                int si=0,sj=0,sk=0;
                for(int i = 0; i < 3 * n; i++){
                    string line = Console.ReadLine();
                    string[] tokens = line.Split();
                    string bib = tokens[0];
                    string ss = tokens[1];
                    string dd = tokens[2];
                    if(ss.Equals("S1")){
                        us[ht[bib]].S1 = dd;
                        s1[si++] = dd;
                    }
                    else if(ss.Equals("S2")){
                        us[ht[bib]].S2 = dd;
                        s2[sj++] = dd;
                    }
                    else {
                        us[ht[bib]].Finish = dd;
                        f[sk++] = dd;
                    }
                }
                Array.Sort(us);
                Array.Sort(s1);
                Array.Sort(s2);
                Array.Sort(f);
                for(int i=0;i<n;i++){
                    for(int j=0;j<n;j++){
                        if(s1[j].Equals(us[i].S1)){
                            us[i].R1 = i+1;
                        }
                    }
                    for(int j=0;j<n;j++){
                        if(s2[j].Equals(us[i].S2)){
                            us[i].R2 = i+1;
                        }
                    }
                    for(int j=0;j<n;j++){
                        if(f[j].Equals(us[i].Finish)){
                            us[i].R3 = i+1;
                        }
                    }
                }
            }
        }
    }
}
