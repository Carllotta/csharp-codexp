using System;

namespace ListaArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite os produtos que precisa comprar, para gerar uma lista!");
            
            string[] produtos = new string [6];

            int contador = 0;

            while (contador <6){
                Console.WriteLine("Digite o produto:");
                produtos [contador] = Console.ReadLine();
                
                contador++;
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Os produros que você precisa comprar são:");
            Console.WriteLine("-----------------------------------------");

             contador=0;
             while (contador <6){
                 Console.WriteLine($"Produto nº {contador+1} : {produtos[contador]}");
                 contador++;
             }
             Console.WriteLine("----------------------------------------");

        }
    }
}
