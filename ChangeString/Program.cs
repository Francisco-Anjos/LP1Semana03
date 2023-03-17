using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a string");
            string phrase = Console.ReadLine();

            Console.WriteLine("Now give me a character");
            string character = Console.ReadLine();

            string newphrase = "";

                
            foreach (var t in phrase)
            {
                if (t.ToString() != character) 
                {
                    newphrase += t;
                }
            }
            Console.WriteLine(newphrase);

        }
    }
}
