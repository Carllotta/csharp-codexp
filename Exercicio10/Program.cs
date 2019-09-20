using System;

namespace Exercico10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário fixo;");
            float salarioFixo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total das suas dívidas:");
            float totalDividas = float.Parse(Console.ReadLine());

            float sobra = salarioFixo-totalDividas;

            Console.WriteLine($"Pagando todas as suas dívidas, sobrará R${sobra} do seu salário.");
        }
    }
}
