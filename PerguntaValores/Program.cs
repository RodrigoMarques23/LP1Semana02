using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir e converter valores
            Console.WriteLine("Inserir Altura");
            double Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserir Raio");
            double Raio = double.Parse(Console.ReadLine());

            //Calcular Valores
            double Volume = Math.PI * Raio * Raio * Altura;
            double Superficie = 2 * Math.PI * Raio * (Raio + Altura);

            //Imprimir valores
            Console.WriteLine($"Volume é = {Volume:f2}");
            Console.WriteLine($"Area de superficie é = {Superficie:f2}");
        }
    }
}
