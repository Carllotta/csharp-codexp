using System;

namespace MediaFaltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua nota 1:");
            float nota1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Digite sua nota 2:");
            float nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a o total das duas faltas:");
            int faltas = int.Parse(Console.ReadLine());

            double  media = (nota1+nota2)/2;

            if (media >= 50 && faltas <=30){
                Console.WriteLine($"Olá {nome}, você foi APROVADO!");
            } else {
                Console.WriteLine($"Olá {nome}, você foi REPROVADO!");
            }
        }
    }
}
