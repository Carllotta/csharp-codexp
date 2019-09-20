using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite seu salário base:");
            float salarioBase = float.Parse(Console.ReadLine());


            if (salarioBase < 990) {
                float acressimo = (salarioBase*30)/100;
                float salarioAtual = salarioBase + acressimo;
                Console.WriteLine($"Olá, você tem direito ao reajuste, seu salário atualizado é de R${salarioAtual}");

            } else {
                Console.WriteLine ("Olá, você não tem direito ao aumento salarial!");
            }
        }
    }
}
