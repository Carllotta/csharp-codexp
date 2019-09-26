using System;

namespace funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mensagemBoasVindas());

            Console.WriteLine("Digite o primeiro numero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());

            int resultadoSoma = somaDeDoisNumeros (numero1,numero2);

            Console.WriteLine($"O resultado da soma é {resultadoSoma}");

           
        } // fim do main
        /// <summary>Efetua a soma de dois número inteiros</summary>
        /// <param name= "a"> Primeiro valor inteiro </param>
        /// <param name="b">Segundo valor inteiro </param>
        /// <returns> Retorna a soma dos dois números inteiros </returns> ///
         

         public static int somaDeDoisNumeros (int a , int b)
            {
                int soma = a + b;

                return soma;
            }

        /// <summary> Retorna texto de boas vindas </summary>
                public static string mensagemBoasVindas ()
        {
            return "Bem vindo ao SENAI de Inforfmática!";
        }
    }
}
