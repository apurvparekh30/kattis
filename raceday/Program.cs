using System;

namespace raceday
{
    class Program
    {
        static class user:IComparable <user> {
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
                set { bit = value; }
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
            public int compareTo(user other){
                return last.CompareTo(other.last);
            }    
        }
        static void Main(string[] args)
        {
            
        }
    }
}
