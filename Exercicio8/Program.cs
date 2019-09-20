using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {   float cotacaoDolar ;
            float valorReal;

            Console.WriteLine("Digite o valor da cotação atual do dólar:");
            cotacaoDolar = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor em Reais que deseja converter em dólar:");
            valorReal = float.Parse(Console.ReadLine());

            float valorConvertido = cotacaoDolar*valorReal;

            Console.WriteLine($"O valor real, convertido em dólar é de U${valorConvertido}");
        }
    }
}
