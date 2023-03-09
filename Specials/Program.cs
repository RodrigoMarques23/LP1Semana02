using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Max and Min
            Console.WriteLine($"Maximo Int = {int.MaxValue}");
            Console.WriteLine($"Minimo Int = {int.MinValue}");
            Console.WriteLine($"Maximo Double = {double.MaxValue}");
            Console.WriteLine($"Minimo Double = {double.MinValue}");
            Console.WriteLine($"Maximo Sbyte = {sbyte.MaxValue}");
            Console.WriteLine($"Minimo Sbyte = {sbyte.MinValue}");
            Console.WriteLine($"Maximo Long = {long.MaxValue}");
            Console.WriteLine($"Minimo Long = {long.MinValue}");
            Console.WriteLine($"Maximo Float = {float.MaxValue}");
            Console.WriteLine($"Minimo Float = {float.MinValue}");

            //Specials
            Console.WriteLine($"Infinito Positivo = {double.PositiveInfinity}");
            Console.WriteLine($"Infinito Negativo = {double.NegativeInfinity}");
            Console.WriteLine($"Não é um numero = {double.NaN}");

        }
    }
}
