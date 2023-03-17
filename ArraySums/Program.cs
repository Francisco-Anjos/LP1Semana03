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
            Console.Writeline(" The Sum of all the rows ");
            for (int i = 0; i < x ; i++)
            {
                float sum = 0;

                for (int j = 0; i < y; j++)
                {
                    sum += matriz [i,j];
                }
                Console.WriteLine($"For your row {i} the sum of its numbers is {sum}");
                for (int j = 0; j < y ; j++)
            {
                float sum = 0;

                for (int i = 0; i < x; i++)
                {
                    sum += matriz [i,j];
                }
                Console.WriteLine($"For your Coliumn {j} the sum of its numbers is {sum}");
                }
            }
        }
    }
}
