using System;

namespace ExerExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salário mínimo atual:");
            float salarioMin = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas você trabalhou no mês?");
            int horasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dependentes você tem?");
            int numDependentes = int.Parse(Console.ReadLine());

            Console.WriteLine("Você fez horas extras? Se sim, quantas?");
            int horasExtra = int.Parse(Console.ReadLine());

            float calcHora = salarioMin/5;
            float calcSalario = horasTrab * calcHora;
            int calcDependentes = numDependentes * 64;
            float calcHoraExtra =  (calcHora +(calcHora*50)/100);
            
            // init salarioBruto; 
            // switch (salarioBruto){
            //     case "1":
            //     if (calcSalario < 1750)
            // }


            // int salarioBruto = calcSalario + calcDependentes + calcHoraExtra;
            Console.WriteLine($"{calcHora} / {calcSalario} / {calcDependentes} / {calcHoraExtra}");
        }
    }
}
