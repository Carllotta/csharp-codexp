using System;

namespace RodizioVeicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, para descobrir qual é o dia de rodizio do seu veículo, digite sua placa. (Sem pontos,traços ou espaço)");
            string digito = Console.ReadLine();

            int caracteres = digito.Length;
      
            int final = int.Parse(digito.Substring(caracteres - 1));

            string resultado;

            if (final == 0 || final == 1){
                resultado = "Segunda-Feira";
            } else if (final == 2 || final == 3){
                resultado = "Terca-Feira";
            }else if (final == 4 || final == 5){
                resultado = "Quarta-Feira";
            }else if (final == 6 || final == 7){
                resultado = "Quinta-Feira";
            }else{
                resultado = "Sexta-Feira";
            }
            
            Console.WriteLine($"O dia de rodízio do seu carro é {resultado}.");
        }
    }
}
