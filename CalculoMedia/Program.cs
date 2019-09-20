using System;

namespace CalculoMedia
{
    class Program
    {
        private const int V = 3;

        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3; 
            

           Console.WriteLine("Digite sua nota 1:");
            nota1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite sua nota 2:");
            nota2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua nota 3:");
            nota3 = int.Parse(Console.ReadLine());

           float soma = (nota1+nota2+nota3);
           float media = (soma/3);
            Console.WriteLine($"Sua média é: {media}");
        }
    }
}
