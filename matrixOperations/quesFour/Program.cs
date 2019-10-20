using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quesFour
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int[,] ar1 = new int[2, 2];
            int[,] ar2 = new int[2, 2];

            //making instance of the class Program      
            Program P1 = new Program();

            //Calling public input function of class Program
            Console.WriteLine("Enter elements of ar1");
            P1.input(ar1);
            Console.WriteLine("");

            Console.WriteLine("Enter elements of ar2");
            P1.input(ar2);
            Console.WriteLine("");

            //storing the values of array3 returned by add function in ar3
            int[,]ar3=P1.add(ar1, ar2);

            //showing results
            P1.output(ar3);

            //storing the values of array3 returned by sub function in ar3
            int[,] ar4 = P1.sub(ar1, ar2);

            //showing results
            P1.output(ar4);

            //storing the values of array3 returned by mulConstant function in ar3
            int k = Int32.Parse(Console.ReadLine());
            int[,] ar5 = P1.mulK(ar1,k);

            //showing results
            P1.output(ar5);

            //storing the values of array3 returned by sub function in ar3
            int[,] ar6 = P1.transpose(ar1);

            //showing results
            P1.output(ar6);

            //storing the values of array3 returned by sub function in ar3
            int[,] ar7 = P1.multiply(ar1,ar2);

            //showing results
            P1.output(ar7);

            Console.Read();
        }

       

        //input array
        public void input(int[,] ar)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
        }

        //show one array
        public void output(int[,] ar)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ar[i, j]+"\t"); 
                }
                Console.WriteLine("");
            }
           
        }

        //Add two arrays
        public int[,] add(int[,] ar1,int[,] ar2)
        { int[,] ar3= new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar3[i,j]=ar1[i,j]+ar2[i,j];
                }
                Console.WriteLine("");
            }
            return ar3;
        }

        //Subtract two arrays
        public int[,] sub(int[,] ar1, int[,] ar2)
        {
            int[,] ar3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar3[i, j] = ar1[i, j] - ar2[i, j];
                }
                Console.WriteLine("");
            }
            return ar3;
        }

        //Multiply by a constant
        public int[,] mulK(int[,] ar1,int k)
        {
            int[,] ar3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar3[i, j] = ar1[i, j] * k;
                }
                Console.WriteLine("");
            }
            return ar3;
        }

        //Transpose
        public int[,] transpose(int[,] ar1)
        {
            int[,] ar3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar3[i, j] = ar1[j,i];
                }
                Console.WriteLine("");
            }
            return ar3;
        }

        //Multiplication
        public int[,] multiply(int[,] ar1, int[,] ar2)
        { 
            int[,] ar3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    ar3[i, j] = 0;

                    for(int k=0;k<2; k++)
                    {
                        ar3[i, j] += ar1[i, k] * ar2[k, j];
                    }
                }
                Console.WriteLine("");
            }
            return ar3;
        }




    }
}
