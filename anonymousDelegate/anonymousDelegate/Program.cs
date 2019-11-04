using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymousDelegate
{
    public delegate void myDelegate(int n);
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
    
            temp = Int32.Parse(Console.ReadLine());
            myDelegate M = delegate (int val)
            {
                Console.WriteLine("Lets Start Counting");
                for (int i = 1; i <= val; i++)
                {
                    Console.WriteLine(i);
                }
            };
            M(temp);
            Console.Read();
        }
    }

}
