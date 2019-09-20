using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da tabuada que deseja fazer:");
            int valor = int.Parse(Console.ReadLine());

            int i = 1;
            int multi;

            while (i <=10) {
                
                multi = valor * i;
                
                Console.WriteLine($"{valor} x {i} = {multi}");
                i = i + 1;
            }
        }
    }
}
