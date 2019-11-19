using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProgram
{
    class Program
    { string input;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.getInput();
            Console.WriteLine("Thankyou! Have a nice day :)");
            Console.Read();
        }
        public void getInput()
        {
           
            try
            {
                Console.WriteLine("Enter Name");
                input = Console.ReadLine();
                char a = char.ToUpper(input[0]);

                if (input[0] != a)
                {
                    invalidLetter A = new invalidLetter("First letter should be Capital");
                    throw A;
                }
            }
            catch (invalidLetter e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("");

                getInput();

            }

        }

    }
    public class invalidLetter : Exception
    {
        public invalidLetter(string s)
        {
            Console.WriteLine(s);
        }
    }
}
