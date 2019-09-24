using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo IMC");
            string[] nome = new string[3];
            int[] idade = new int[3];
            double [] peso = new double[3];
            double [] altura = new double[3];
            string [] sexo = new string[3];
            
            int somaIdadeFem = 0;
            int somaIdadeMasc = 0;
            int somaSexFem = 0;
            int somaSexMasc = 0;
            double somaPesoFem = 0;
            double somaPesoMasc = 0;
            double somaAltFem = 0;
            double somaAltMasc = 0;
            

            for (int i=0 ; i < 3; i++)
            {
                Console.WriteLine("Digite seu nome:");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite sua idade:");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso:");
                peso[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua altura:");
                altura[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu sexo(feminino/masculino):");
                sexo[i] = Console.ReadLine();
                
                if ( sexo[i] == "feminino") {
                    somaIdadeFem += idade[i];
                    somaSexFem++;
                    somaAltFem += altura[i];
                    somaPesoFem += peso [i];

                }else {
                    somaIdadeMasc += idade[i];
                    somaSexMasc++;
                    somaAltMasc += altura [i];
                    somaPesoMasc += peso [i];
                }

            } 
            for(int i = 0; i < 3; i++) {
                Console.WriteLine($"{nome[i]}, {sexo[i]}, peso: {peso[i]} e altura: {altura[i]}, seu IMC é: {peso[i]/(altura[i] * altura[i])}");
            }
            Console.WriteLine($"O total de homens é {somaSexMasc}, a media de idade é {somaIdadeMasc/somaSexMasc} \n O total de mulheres é {somaSexFem}, a media de idade é {somaIdadeFem/somaSexFem}.");

        }
    }
}
