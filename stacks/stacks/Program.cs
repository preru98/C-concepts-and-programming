using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("A");
            numbers.Push("B");
            numbers.Push("C");
            numbers.Push("D");
            numbers.Push("E");

            Console.WriteLine("Displaying Stack\n");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Popping Last Element...\n");
            numbers.Pop();

            Console.WriteLine("Displaying Stack\n");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.Read();

 

        }
    }
}
