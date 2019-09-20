using System;

namespace ExerNovos3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do seu salário base:");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite um dos códigos da tabela para selecionar o seu cargo:");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" ( 1 ) Escrituário");
            Console.WriteLine(" ( 2 ) Secretário");
            Console.WriteLine(" ( 3 ) Caixa");
            Console.WriteLine(" ( 4 ) Gerente");
            Console.WriteLine(" ( 5 ) Diretor");
            Console.WriteLine("--------------------------------------------");

            string resposta = Console.ReadLine();
            

            switch(resposta) {
                case "1":
                float aumento1 = salario +((salario*50)/100);
                Console.WriteLine($"Olá, {nome}! Seu salário é de R${salario}. Você digitou o código {resposta}, no seu cargo de Escrituário, o aumento salarial foi de 50%, portanto o seu salário com resjuste vai ficar no valor de R${aumento1}.");
                break;
                case "2":
                float aumento2 = salario +((salario*35)/100);
                Console.WriteLine($"Olá, {nome}! Seu salário é de R${salario}. Você digitou o código {resposta}, no seu cargo de Secretário, o aumento salarial foi de 35%, portanto o seu salário com resjuste vai ficar no valor de R${aumento2}.");
                break;
                case "3":
                float aumento3 = salario +((salario*20)/100);
                Console.WriteLine($"Olá, {nome}! Seu salário é de R${salario}. Você digitou o código {resposta}, no seu cargo de Caixa, o aumento salarial foi de 20%, portanto o seu salário com resjuste vai ficar no valor de R${aumento3}.");
                break;
                case "4":
                float aumento4 = salario +((salario*10)/100);
                Console.WriteLine($"Olá, {nome}! Seu salário é de R${salario}. Você digitou o código {resposta}, no seu cargo de Gerente, o aumento salarial foi de 10%, portanto o seu salário com resjuste vai ficar no valor de R${aumento4}.");
                break;
                case "5":
                Console.WriteLine($"Olá, {nome}! Seu salário é de R${salario}. Você digitou o código {resposta}, no seu cargo de Diretor, não há aumento salarial.");
                break;
                default:
                Console.WriteLine($"Olá, {nome}! Escolha um dos códigos da tabela.");
                break;
            }
        }
    }
}
