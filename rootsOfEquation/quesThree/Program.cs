using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesThree
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1,x2,d,du;
            int ch = 1;
            while(ch==1)
            { 
            Console.WriteLine("Enter a");
            a =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            c = double.Parse(Console.ReadLine());

            d = ((Math.Pow(b, 2)) - (4 * a * c));
            if(d<0)
                Console.WriteLine("Imaginary roots");
            else if(d==0)
            {
                x1 = ((-b )/ (2 * a));
                Console.WriteLine("Two equal roots : " + x1 + ", " + x1);
            }
            else
            {
                du = Math.Sqrt(d);
                x1 = ((-b + du) / (2 * a));
                x2 = ((-b - du) / (2 * a));
                Console.WriteLine("Two distinct roots : " + x1 + ", " + x2);
            }
                Console.WriteLine("Enter 1 to continue");
                ch = Int32.Parse(Console.ReadLine());
            }
            Console.Read();


        }
    }
}
