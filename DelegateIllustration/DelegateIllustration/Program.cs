using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateIllustration
{
    public delegate void myDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            Illustration I = new Illustration();
            myDelegate Obj = new myDelegate(I.func);
            Obj();
            Console.Read();
        }
    }
    class Illustration
    {
        public void func()
        {
            Console.WriteLine("I am from func method");
        }
    }
}
