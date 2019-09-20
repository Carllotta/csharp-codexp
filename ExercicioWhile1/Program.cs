using System;

namespace ExercicioWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laço de repetição while!");

            Console.WriteLine("Digite o valor inicial");
            int inicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor Limite:");
            int limite = int.Parse(Console.ReadLine());

            while(inicial<= limite){
                
                Console.WriteLine(inicial);
                inicial = inicial + 1;
            } //fim do while
        }
    }
}
