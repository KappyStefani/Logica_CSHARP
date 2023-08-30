using System;
using System.Security.Cryptography.X509Certificates;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma, troca;

            Console.WriteLine("Digite dois números: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            if(x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }

            soma = 0;

            for(int i = x+1; i < y; i++) 
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("Soma dos impares: " + soma);

        }
    }
}