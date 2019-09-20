using System;

namespace mediaEscolar
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine ();

            Console.WriteLine("Digite sua nota 1:");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota 2:");
            float nota2 = float.Parse (Console.ReadLine());

            float media = (nota1+nota2)/2;

            string resultado;
            if (media >= 7) {
                resultado = "Aprovado";              
            } else{
                resultado = "Reprovado";
            }

            Console.WriteLine($"Olá, {nome}, sua média é {media}  portanto você foi {resultado}!");
        }
    }
}
