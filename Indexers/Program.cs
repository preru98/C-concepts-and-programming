 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class IndexersIllustration
    {
        private String[] myStringStore = new String[3];

        public String this [int index]{
            get
            {
                return myStringStore[index];
            }

            set
            {
                myStringStore[index]=value;
            }
        } 

    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexersIllustration I = new IndexersIllustration();
            I[0] = "Henlo :1";
            I[1] = "Henlo :2";
            I[2] = "Henlo :3";
            Console.WriteLine(I[1]);
            Console.Read();
        }
    }
}
