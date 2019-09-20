using System;

namespace Cargos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cargos com Switch");

            Console.WriteLine("Digite o número do cargo para descobrir o salario:");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" ( 1 ) Diretor");
            Console.WriteLine(" ( 2 ) Gerente");
            Console.WriteLine(" ( 3 ) Professor");
            Console.WriteLine(" ( 4 ) Coordenador");
            Console.WriteLine(" ( 5 ) Atendente");
            Console.WriteLine("-----------------------");

            string resposta = Console.ReadLine();

            switch (resposta){
                case "1" :
                Console.WriteLine("O salário de Diretor ´r fr R$18.000");
                break;
                case "2":
                Console.WriteLine("O salário de Gerente é de R$12.000");
                break;
                case "3":
                Console.WriteLine("O salário de Professor é de R$4.000");
                break;
                case "4":
                Console.WriteLine("O salário de Coordenador é de R$7.500");
                break;
                case "5":
                Console.WriteLine("O salário de Atendente é de R$2.000");
                break;
                default:
                Console.WriteLine("Digite um dos valores da lista.");
                break;
            }
        }
    }
}
