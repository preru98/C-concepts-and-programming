using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            long num, counter,sum,digit,counterInUse;
            int ch = 1;
            while (ch == 1)
            {
                counter = 1; sum = 0;
                Console.WriteLine("Enter number");
                num = long.Parse(Console.ReadLine());            //coverting string
                long numInUse = num;
                long compareNum = num;
                while (num >= 10)
                {
                    num = num / 10;
                    counter++;
                }
                counterInUse = counter;
                while (counter >= 0)
                {
                    digit = numInUse % 10;
                    numInUse /= 10;
                    sum += (long)Math.Pow(digit, counterInUse); //Math.Pow returns double type value ,converting numeric value
                    counter--;
                }
                if (sum == compareNum)
                    Console.WriteLine("Number is Amstrong ");
                else
                    Console.WriteLine("Number is not Amstrong ");

                Console.WriteLine("Press 1");
                ch = Int32.Parse(Console.ReadLine());
            }
           
            Console.Read();

        }
          
    }
}
