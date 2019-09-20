using System;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorTarifa = 4.30f;
            Console.WriteLine("Digite a quantidade de passageiros que entraram no ônibus:");
            int passageiros = int.Parse(Console.ReadLine());
            
            float totalArrecadado = valorTarifa * passageiros;

            Console.WriteLine($"O valor total arrecadado é de R${totalArrecadado}");
        }
    }
}
