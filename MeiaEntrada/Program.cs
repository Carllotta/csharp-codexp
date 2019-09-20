using System;

namespace MeiaEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, para saber se você tem direito a meia entrada, digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            
            if (idade < 18 || idade >=60){
                Console.WriteLine("Olá, você tem direito a meia entrada!");
            } else {
                Console.WriteLine("Olá, infelizmente você não tem direito a meia entrada!");
            }
        }
    }
}
