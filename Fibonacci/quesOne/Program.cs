using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesOne
{
    class Program
    {
        static void Main(string[] args)
        {
            long n, a, b, c, flag;
            int ch=1,num;
            while (ch==1)
            {
                n = 2; a = 0; b = 1; c = 1; flag = 0;
       
                Console.WriteLine("Enter number");
                 num = Int32.Parse(Console.ReadLine());
                if (num == 0 || num == 1)
                    flag = 1;
                if (num == 0)
                    Console.WriteLine(num + " Exists at index " + num + " given starting index of series as 0.");
                else if (num == 1)
                    Console.WriteLine(num + " Exists at index " + num + " given starting index as 0.");

                while (c <= num)
                {
                    c = a + b;
                    if (num == c)
                    {
                        Console.WriteLine(num + " Exists at index " + n + " given starting index as 0.");
                        flag = 1;
                    }
                    a = b;
                    b = c;
                    n++;
                }
                if (flag == 0)                
                    Console.WriteLine(num + " does not exists in the series.");

                Console.WriteLine("Enter 1 to continue and 0 to exit.Thankyou.");
                    ch = Int32.Parse(Console.ReadLine());
                
            }
            Console.Read();
        }
    }
}
