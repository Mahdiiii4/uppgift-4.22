using System;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
         for(int i = 10; i <= 30; i++)

             Console.WriteLine(i);

         for (int j = 200; j >= 180; j--) 

                Console.WriteLine(j--);

         for (int g=1000; g<=1400; g+=50)

                Console.WriteLine(g);
        }
    }
}