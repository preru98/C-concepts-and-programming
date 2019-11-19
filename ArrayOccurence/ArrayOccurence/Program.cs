using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOccurence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            Console.WriteLine("Enter size of array");
            int size = Int32.Parse(Console.ReadLine());
            arr = new int[size];
            Console.WriteLine("Enter elements of array");
            Console.WriteLine("");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter element");
            int ele = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == ele)
                {
                    count++;
                    Console.WriteLine("Found at index " + i);
                }
            }
            Console.WriteLine("Total occurence of " + ele + " : " + count);
            Console.Read();
        }
    }
}
