using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOne
{ public delegate void eventHandler();            //declaration of delegate

    class myControl
    {
        public event eventHandler someEvent;
        public void onsomeEvent()
        {
            if (someEvent != null)
                someEvent();
        }
    }
    class Program
    {   static void handle()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            myControl M = new myControl();
            M.someEvent += handle;
            M.onsomeEvent();
            Console.Read();
        }
    }
}
