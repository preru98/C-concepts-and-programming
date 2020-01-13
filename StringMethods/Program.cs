using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello PI 3.14 ";
            string str2, str3,str4;
            str3 = "Hi, Root Three 1.73";
       
            char[] charArray = str1.ToCharArray();
            Array.Reverse(charArray);
            str2 = new string(charArray);
            Console.WriteLine("Contents of str1   : "  + str1);
            Console.WriteLine("Reverse  of  str1  : "  + str2);
            Console.WriteLine(String.Concat(str1, str3));
            str4 = String.Copy(str1);
            Console.WriteLine("Contents of str4   : " + str4);
            Console.WriteLine(str1.Replace("PI", "pi"));

            Console.Read();
        
        }
    }
}
