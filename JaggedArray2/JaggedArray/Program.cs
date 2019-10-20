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
            int countB = 2;
            array = new int[n][];

            for(int i = 0,j=1; i < n; i++,j++)
            {
                array[i] = new int[j];
            }
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < array[i].Length; j++)
                {
                    if ((i+1) % 2 == 0)
                    {
                        array[i][j] = countB;
                        countB += 2;
                    }

                    else
                    {
                        array[i][j] = countA;
                        countA += 2;
                    }
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
/*
1 
2 4
3 5 7
6 8 10 12
9 11 13 15 17
*/
