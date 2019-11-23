using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Program
    {   static void square()
        {
            Console.WriteLine("x * x");
        }
        public static void Main(string[] args)
        {
            Action myDelegate = square;
            myDelegate();
            Console.ReadKey();
            //Action -> Min 1 & Max 16 input characters and 0 output parameters
        }
    }
}
