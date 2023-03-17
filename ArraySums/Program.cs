using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me how many horizontal lines");
            int x = Console.ReadLine();

            Console.WriteLine("Tell me how many Vertical lines");
            int y = Console.ReadLine();

            float [,] matriz =  new float[x,y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y ; j++)
                {
                    Console.WriteLine($"Youre in {1},{j} position");
                    Console.WriteLine("Give me a number");
                    
                    matriz[i,j] = Console.ReadLine();
                    

                }
            }

        }
    }
}
