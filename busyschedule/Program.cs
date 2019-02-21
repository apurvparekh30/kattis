using System;

namespace busyschedule
{
    class Program
    {
        static int n;
        static Schedule []schedule;

        class Schedule : IComparable{
            string hour;
            string minute;
            string zone;
            public Schedule(string hour,string minute,string zone){
                this.hour = hour;
                this.minute = minute;
                this.zone = zone;
            }
            public int CompareTo(Object other){
                Schedule o = (Schedule) other;
                int h = int.Parse(this.hour)%12;
                int hh = int.Parse(o.hour)%12;
                int m = int.Parse(this.minute);
                int mm = int.Parse(o.minute);
                if(this.zone.Equals(o.zone)){
                    if(h == hh)
                        return m.CompareTo(mm);
                    return h.CompareTo(hh);
                }
                return this.zone.CompareTo(o.zone);
            }

            public override string ToString(){
                return hour+":"+minute+" "+zone;
            }
        }
        static void Main(string[] args)
        {
            while(true){
                n = int.Parse(Console.ReadLine());
                if(n==0)
                    break;
                schedule = new Schedule[n];
        
                for(int i=0;i<n;i++){
                    string next = Console.ReadLine();
                    string []tokens = next.Split(new char[]{':',' '});
                    schedule[i] = new Schedule(tokens[0],tokens[1],tokens[2]);
                }
                Array.Sort(schedule);
                foreach(Schedule s in schedule){
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }
    }
}
