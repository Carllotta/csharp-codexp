using System;
using poo.Models;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno1 = new AlunoModel();

            Console.Clear();

            System.Console.WriteLine("Insra o nome do aluno:");
            aluno1.Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o curso:");
            aluno1.Curso = Console.ReadLine();

            System.Console.WriteLine("Insira a idade:");
            aluno1.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira o Rg:");
            aluno1.Rg = int.Parse(Console.ReadLine());

            System.Console.WriteLine($@"
            Nome: {aluno1.Nome}
            Curso: {aluno1.Curso}
            Idade: {aluno1.Idade}
            Rg: {aluno1.Rg}
            ");
        }
    }
}
