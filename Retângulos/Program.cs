using System;
using System.Security;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, base1, area, perimetro, diagonal, diagonal1;

            Console.WriteLine("Base do retângulo: ");
            base1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Altura do retângulo: ");
            altura = double.Parse(Console.ReadLine());

            area = altura * base1;
            perimetro = (altura + base1) * 2;
            diagonal = Math.Sqrt(Math.Pow(altura, 2.0) + Math.Pow(base1, 2));
            


            Console.WriteLine("Area: "+ area.ToString("F4"));
            Console.WriteLine("Perimetro: "+ perimetro.ToString("F4"));
            Console.WriteLine("Diagonal: "+ diagonal.ToString("F4"));

            




        }
    }
}