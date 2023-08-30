using System;
namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2, n3;

            Console.WriteLine("Primeiro número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Terceiro número");
            n3 = Convert.ToInt32(Console.ReadLine());

            if(n1 < n2 && n1 < n3)
            {
                Console.WriteLine("O menor número é: " + n1);
                    
            }
            else
            {
                if(n2 < n3 && n2 < n1)
                {
                    Console.WriteLine("O menor número é " + n2);
                }
                else 
                {
                    Console.WriteLine("O menor número é " + n3);
                }
            }
            

        }
    }
}