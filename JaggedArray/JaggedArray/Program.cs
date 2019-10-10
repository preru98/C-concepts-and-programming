using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged
{
    public class jaggedArray
    {
        int[][] array;

        public void construct(int n)
        {
            int countA = 1;
       
            array = new int[n][];

            for(int i = 0,j=1; i < n; i++,j++)
            {
                array[i] = new int[j*2];
            }
            for (int i = 0; i < n; i++,countA++)
            {
                
                for (int j = 0; j < array[i].Length; j++)
                {

                    array[i][j] = countA;
                }
                   
            }

        }

        public void show()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j]+"  ");
            }
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            jaggedArray J = new jaggedArray();
            J.construct(5);
            J.show();
            Console.Read();
        }
    }
}
