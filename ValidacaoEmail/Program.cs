using System;

namespace ValidacaoEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de Email");

            string email;
            

            do {
                Console.WriteLine("Digite seu Email:");
                email = Console.ReadLine();
            } 

            while (!email.Contains("@") || !email.Contains("."));
                
        }
    }
}
