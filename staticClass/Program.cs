using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClass
{
    class StaticClassIllustration
    {
        static public int count = 0;
        private StaticClassIllustration()
        {
            Console.WriteLine("I will never be called");
        }
        public static void setCount(int n)
        {
            count = n;
        }
        public static int getCount()
        {
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //StaticClassIllustration S;
            StaticClassIllustration.setCount(4);
            Console.WriteLine("Current value of count : " + StaticClassIllustration.getCount());
            Console.Read();


        }
    }
}
