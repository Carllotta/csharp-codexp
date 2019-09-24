using System;

namespace ListaProdutoComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Produto com For:");

            string [] produtoNome = new string [3]; //camel case
            double [] produtoPreeco = new double [3];

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Digite o nome do {i+1}º produto");
                produtoNome[i] = Console.ReadLine();
                Console.WriteLine("Digite o Preço:");
                produtoPreeco[i] = double.Parse(Console.ReadLine());
            } //fim do for

            // foreach (int i =0; i < 3; i++){
            //     Console.WriteLine($"Produto: {produtoNome[i]}, valor {produtoPreco[i]}");
            // }
            foreach (var produto in produtoNome)
            {
                Console.WriteLine($"Produto: {produto}");
            }
        }
    }
}
