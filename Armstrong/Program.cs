using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int ch = 1;
            while (ch == 1)
            {
                Console.WriteLine("Hi! Please Enter Number");
                number = Int32.Parse(Console.ReadLine());
                Armstrong A = new Armstrong(number);

                Console.WriteLine("Press 1 to continue");
                ch = Int32.Parse(Console.ReadLine());

            }
            Console.Read();
        }
       
    }
    class Armstrong
    {
        private int number;
        public int numLength;
        private string result;
        public Armstrong(int num)
        {
            number = num;
            numLength = calc();
            result = check();
            Console.WriteLine(result);
        }
        public int calc()
        {
            int num = number,count=0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            return count;
        }
        public string check()
        {
           int num = number;double revNum=0,sum;int  rem;
           int pow =numLength ;string Result; 

           
            while (num > 0)
            {
               rem=num % 10;
                //sum= Math.Pow(rem, pow);

                //calculating power
                sum = 1;
                for(int i = 0; i < pow; i++)
                {
                    sum *= rem;
                }

               revNum += sum;
               num/= 10;
            }

            //Console.WriteLine(revNum);
            
            if (revNum == number)
                Result = "YES";
            else
                Result = "NO";
            return Result;
            
        } 
    }
}
