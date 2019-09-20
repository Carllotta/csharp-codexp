using System;

namespace ConversaodeIdade
{
    class Program
    {
        static void Main(string[] args)
        {  
            int idade;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            int idadeMeses = idade*12;
            int idadeDias = idade*365;
            int idadeHoras = idadeDias*24;
            int idadeMinutos = idadeHoras*60;

            Console.WriteLine($"Em {idade} anos, você viveu {idadeMeses} meses, {idadeDias} dias, {idadeHoras} horas e {idadeMinutos} minutos!");
        }
    }
}
