using System;

namespace Idade_em_Semanas
{
    class Program
    {
        static void Main(string[] args)
        {
            int semanaAno = 48;
            int anoNascimento;
            int anoAtual;
            
            Console.WriteLine("Digite seu ano de nascimento:");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual:");
            anoAtual = int.Parse(Console.ReadLine());

            int idade = anoAtual - anoNascimento;
            int idadeSemanas = idade * semanaAno;

            Console.WriteLine($"Você tem {idade} em anos, e {idadeSemanas} em semanas");
        }
    }
}
