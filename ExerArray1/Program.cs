using System;

namespace ExerArray1
{
    class Program
    {
        static void Main(string[] args)
        {  
            // Objetivo: Efetuar cadastro de  5 usuário com os seguintes
            // dados - NotImplementedException, Telefone e Email.
    
            Console.WriteLine("Exercicio 1 de Array!");

            string [] nomes = new string [3];
            string [] telefones = new string [3];
            string [] emails = new string [3];

            int contador = 0;

            while (contador < 3){
                Console.WriteLine("Digite o seu nome:");
                nomes [contador] = Console.ReadLine();

                Console.WriteLine("Digite seu Telefone:");
                telefones [contador] = Console.ReadLine();
                
                Console.WriteLine("Digite seu E-mail:");
                emails [contador] = Console.ReadLine();

                contador++;

            } 
            contador = 0;
            while (contador < 3) {
                Console.WriteLine($"O cliente nº {contador+1} é {nomes[contador]}, de telefone {telefones[contador]} e email: {emails[contador]}");
                contador++;
            }
        }
    }
}
