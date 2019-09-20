using System;

namespace PimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui é onde inserimos o código 

            int n1;
            int n2;
            float resp;

            Console.WriteLine("Digite o primeiro numero");
            n1= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            
            resp= n1/n2;

            Console.WriteLine($"A soma dos valores é: {resp} ");
            
        }
    }
}
