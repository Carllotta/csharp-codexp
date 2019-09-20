using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {   float valorProduto;
            float percentual;

            Console.WriteLine("Digite o valor de aquisição do seu produto:");
            valorProduto = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percecntual a ser aplicado na venda:");
            percentual = float.Parse(Console.ReadLine());

            
            float valorPercentual = ((valorProduto*percentual)/100);
            float valorFinal = valorPercentual + valorProduto;

            Console.WriteLine($"O valor de venda do seu produto, com o percentual de acréssimo aplicado é de R${valorFinal}");


         }
    }
}
