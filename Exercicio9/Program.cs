using System;

namespace Exerciocio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digute seu salario fixo:");
            float salarioFixo = float.Parse(Console.ReadLine());

            Console.WriteLine ("Digite o valor total de vendas no mês:");
            float valorVendas = float.Parse(Console.ReadLine());

             float salarioAtual = salarioFixo + ((valorVendas*10)/100);

            Console.WriteLine($"Olá, {nome}, seu salário base é de R${salarioFixo} seu salário com atualizado com a comissão é de R${salarioAtual}");
        }
    }
}
