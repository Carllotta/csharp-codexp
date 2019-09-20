using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {   float salarioBase;
            float valorVendas;


            Console.WriteLine("Digite o valor do seu salário base:");
            salarioBase = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor total de vendas no mês:");
            valorVendas = float.Parse(Console.ReadLine());

            float comissao = ((valorVendas*5)/100);
            float salario = comissao + salarioBase ;

            Console.WriteLine($"O valor do seu salário com a comissão mensal, e de R${salario}");

        }
    }
}
