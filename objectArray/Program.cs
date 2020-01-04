using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectArray
{   class ArrayObjects
    {
        int count = 10;
        String name;

        public ArrayObjects()
        {
            Console.Write("Object Created");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayObjects[] A = new ArrayObjects[10];
            for (int i = 0; i < 10; i++)
            {
                 A[i] = new ArrayObjects(); Console.WriteLine(i+1);
            }
            Console.Read();
        }

    }
}
