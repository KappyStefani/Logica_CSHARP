using System;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double soma, media;

            Console.Write("Quantos números você vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
            
            for(int i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine());

            }

            Console.Write("Números digitados: ");
            

            for(int i = 0; i < N; ++i) 
            {
                Console.Write(vet[i] + " ");               
            }

            soma = 0;

            for(int i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            Console.WriteLine("\nSoma: " + soma);

            media = (double)soma / N;

            Console.WriteLine("Media: " + media);


        }
    }
}