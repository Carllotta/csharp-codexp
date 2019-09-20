using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            float idade = float.Parse(Console.ReadLine());
             string resultado;
            if (idade <=7){
                 resultado = "Infantil A";
            } else if (idade<=10) {
                resultado = "Infantil B";
            } else if (idade<=13){
                resultado = "Juvenil C";
            } else if (idade<=17) {
                resultado = "Juvenil D";
            } else {
                resultado = "Adulto";
            }
             Console.WriteLine($"Você é da categoria {resultado}.");
        }
    }
}
