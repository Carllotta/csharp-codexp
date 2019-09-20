using System;

namespace ExerNovos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores para fazer uma operação!");

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Digite o primeiro valor:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Agora escolha qual operação você deseja realizar (digite um dos valores do menu):");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" ( 1 ) Soma de dois números");
            Console.WriteLine(" ( 2 ) Subtração do primeiro pelo segundo");
            Console.WriteLine(" ( 3 ) Subtração do segundo pelo primeiro");
            Console.WriteLine(" ( 4 ) Multiplicação dos dois numeros");
            Console.WriteLine(" ( 5 ) Divisão do primeiro pelo segundo");
            Console.WriteLine(" ( 6 ) Divisão do segundo pelo primeiro");
            Console.WriteLine("--------------------------------------------");

            string resposta = Console.ReadLine();

            switch (resposta) {
                case "1":
                float soma = num1 + num2;
                Console.WriteLine($"A soma dos dois valores digitados é {soma}");
                break;
                case "2":
                float sub1 = num1 - num2;
                Console.WriteLine($"A subtração do primeiro valor, pelo segundo valor é {sub1}");
                break;
                case "3":
                float sub2 = num2 - num1;
                Console.WriteLine($"A subtração do segundo valor, pelo primeiro valor é {sub2}");
                break;
                case "4":
                float mult = num1 * num2;
                Console.WriteLine($"A multiplicação dos valores é {mult}");
                break;
                case "5":
                if (num2 == 0) {
                    Console.WriteLine("Não é possivel fazer divisão por 0, digite  um segundo valor diferente de 0.");
                } else {
                float div1 = num1/num2;
                Console.WriteLine($"A divisão do primeiro valor pelo segundo é {div1}");
                }
                break;
                case "6":
                if (num1 == 0){
                    Console.WriteLine("Não é possivel fazer divisão por 0, digite um primeiro valor diferente de 0.");
                } else {
                float div2 = num2/num1;
                Console.WriteLine($"A divisão do segundo valor pelo primeiro é {div2}");
                }
                break;
                default :
                Console.WriteLine("Digite um dos valores da lista");
                break;
            }
        }
    }
}
