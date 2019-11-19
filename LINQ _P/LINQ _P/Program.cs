using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_P
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20, 56, -9, 67, 32, 67 };
            var queryArray = from num in array
                             orderby num descending
                             select num;
            Console.WriteLine(" Descending order : ");
            foreach (int i in queryArray)
                Console.Write(i + " | ");
            Console.Read();

        }
    }
}
