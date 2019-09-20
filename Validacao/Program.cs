using System;

namespace Validacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação com DO WHILE");

            string nome;

            do 
            {
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();
            }while(nome.Length<=1);

            string senha;
            do
            { 
                Console.WriteLine("Digite uma senha:");
                senha = Console.ReadLine();
                
            } while (senha.Length<=6);
        }
    }
}
