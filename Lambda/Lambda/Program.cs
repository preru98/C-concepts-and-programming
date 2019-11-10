using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate string myDelegate(int n);
    class Program
    {
        static void Main(string[] args)
        {
            int temp;

            temp = Int32.Parse(Console.ReadLine());
            myDelegate M = (val) => 
            {
                Console.WriteLine("Lets Start Counting");
                for (int i = 1; i <= val; i++)
                {
                    Console.WriteLine(i);
                }
                return "ABC";
            };
            M(temp);
            Console.Read();
        }
    }
}
