using System;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            
            Console.WriteLine("Dados da primeira pessoa: ");
            
            Console.Write("Nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = Convert.ToInt32(Console.ReadLine());

            media = Convert.ToDouble((idade1) + idade2) / 2;

            Console.WriteLine("A media de idade de " + nome1 + " e " + nome2 +  " é de: " + media );
        }
    }
}