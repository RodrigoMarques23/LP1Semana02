using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            x++;
            Console.WriteLine($"Sufixo = {x}");
            --x;
            Console.WriteLine($"Prefixo = {x}");
        }
    }
}
