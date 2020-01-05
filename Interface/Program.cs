using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{    
    interface Ical
    {
        int square(int x);
        int cube(int y);
    }
    interface IcalA : Ical
    {
        new int cube(int z);
    }
    class Program : IcalA
    {
        public int square(int x) 
        {
            return x * x;
        }
        int Ical.cube(int x)
        {
            return x * x * x;
        }
        int IcalA.cube(int x)
        {
            return x ;
        }

        public int meth1(int p)
        {
            return p - 1;
        }
        static void Main(string[] args)
        {
            
            Program P = new Program();
            Program P2 = new Program();
            Ical obj = (Ical)P2;
            IcalA obj2 = (IcalA)P2;
            Console.WriteLine(P.square(5));
            Console.WriteLine(obj.cube(5));
            Console.WriteLine(obj2.cube(5));
            Console.WriteLine(P.meth1(5));
            Console.Read();
        }
    }
}
