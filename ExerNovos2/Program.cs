using System;

namespace ExerNovos2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());
                string resultado1;
                string resultado2;
                string tamanho;
            if (num1 % 2 == 0) {
                // Console.WriteLine($"O número {num1} é um número ímpar.");
                resultado1 = "par";
            } else {
                resultado1 = "ímpar";
            } 
             if (num2 % 2 == 0) {

                resultado2 = "par";
            } else {
                resultado2 = "ímpar";
            }

            if (num1>num2){
                tamanho = "maior";
            } else {
                tamanho = "menor";
            }

            Console.WriteLine($"O número {num1} é {resultado1}, o número  {num2} é {resultado2}. O número {num1} é {tamanho} que o número {num2}.");
        }
    }
}
