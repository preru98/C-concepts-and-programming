using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInheritance
{  
    interface interfaceA
    {
        void school(); 
    }

    interface interfaceB
    {
        void college();
    }

    class baseClassA : interfaceA
    {
        public void school()
        {
            Console.WriteLine("School Name : Yuvshakti Model School");
        }
    }

    class baseClassB : interfaceB
    {
        public void college()
        {
            Console.WriteLine("College Name : Jagan Institute of Management Studies");
        }
    }

    class Program :interfaceA, interfaceB
    {
        baseClassA objA = new baseClassA();
        baseClassB objB = new baseClassB();
        public void school()
        {
            objA.school();
        }
        public void college()
        {
            objB.college();
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.school();
            P.college();
            Console.ReadKey();
        }
    }
}
