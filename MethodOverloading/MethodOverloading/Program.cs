//Swapping Pass by value & Pass by ref
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Program P = new Program();

            Console.WriteLine("Area of Circle with radius 5 units");
            Console.WriteLine(P.Area(5)+"  sqr.units");
            Console.WriteLine("");

            Console.WriteLine("Area of Square with side 10 units");
            Console.WriteLine(P.Area(10.0f) + "  sqr.units");
            Console.WriteLine("");


            Console.WriteLine("Area of Rectangle with length and breadth as 5 and 6 units");
            Console.WriteLine(P.Area(5.0f,6.0f) + "  sqr.units");
            Console.WriteLine("");

            Console.WriteLine("Area of Triangle with sides 5,6 and 10 units");
            Console.WriteLine(P.Area(5.0,6.0,10.0) + "  sqr.units");
            Console.WriteLine("");


            Console.Read();
        }
        public double Area (int radius)
        {   
            double area = 3.14 * radius * radius;
            return area;

        }

        public double Area(float side)
        {
            double area = side * side;
            return area;

        }

        public double Area(float length, float breadth)
        {
            double area = length * breadth;
            return area;

        }

        public double Area(double sideA,double sideB,double sideC)
        {
            double semi = (sideA + sideB + sideC)/2;
            double area = Math.Sqrt(semi * (semi - sideA) * (semi - sideB) * (semi - sideC));
            return area;

        }
    }

}

