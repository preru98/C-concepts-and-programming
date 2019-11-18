using System;


namespace sortNames1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Bangladesh","Denmark","Bhutan","Canada","Dehradun"}; string temp;
            for (int i=0;i<5;i++)
            {
                for (int j=0;j<5;j++)
                {
                    if (String.Compare(array[i],array[j])<0)
                    {
                        temp =array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Array");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(array[i] + "|");
            }
            Console.ReadKey();
        }
    }
}
