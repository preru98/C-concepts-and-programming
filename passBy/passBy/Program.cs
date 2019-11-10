using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passBy
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5;
            int b=90;
            Program P = new Program();
            
            Console.WriteLine("Before Swapping");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("");

            P.swap(a, b);
            Console.WriteLine("After Swapping through pass by value");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("");


            P.swapRef(ref a, ref b);
            Console.WriteLine("After Swapping through pass by reference");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("");

            Console.Read();
        }
        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
     
        }
        public void swapRef(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
            
        }
    }
   
}
