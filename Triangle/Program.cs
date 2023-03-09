using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            char a = char.Parse(args[1]);
            for (int i = 0; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)

                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }

            //Console.WriteLine(x);
            //Console.WriteLine(a);
        }
    }
}
