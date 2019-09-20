using System;

namespace AgenciaTurismo
{
    class Program
    {
        static void Main(string[] args)
        {  // nome, origem, destino e data da do vôo //

            Console.WriteLine("Agência de Turismo");
            string[] nome = new string[2];
            string[] origem = new string[2];
            string[] destino = new string[2];
            DateTime[] data = new DateTime[2];  // variável de armazenamento de datas 
            
            int opcao = 0, contador = 0;
            string resposta = "";
            
            do { 
                Console.WriteLine("Secelione uma opção:");
                Console.WriteLine(" ( 1 ) - Cadastar passagem");
                Console.WriteLine(" ( 2 ) - Listar passagem");
                Console.WriteLine(" ( 0 ) - Sair");
                opcao = int.Parse(Console.ReadLine());

            switch (opcao) {  //inicio do menu
                case 1 :
                  Console.WriteLine("Vamos cadastrar!");
                  do //Inicio do cadastro de passagem
                  { 
                    if(contador < 2){

                    Console.WriteLine("Digite o nome do Passageiro:");
                    nome [contador] = Console.ReadLine();

                    Console.WriteLine("Digite a Origem:");
                    origem [contador] = Console.ReadLine();

                    Console.WriteLine("Digite o Destino:");
                    destino [contador] = Console.ReadLine();

                    Console.WriteLine("Digite a data do vôo:");
                    data [contador] = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Você deseja cadastrar mais um? S/N?"); 
                    resposta = Console.ReadLine();
                    contador++;
                    } else {
                    Console.WriteLine("Numero passagem excedida");
                    }

                  } while (resposta == "S"); // repete o cadastro de cliente se ele dissser que quer cadastrar um novo passageiro (S)
                    break;
                case 2 :
                  Console.WriteLine("Listando as passagenss!");
                  
                int contadorB = 0;
                  
                while (contadorB <2) {
                    Console.WriteLine($"{contadorB+1} passageiro - Nome: {nome[contadorB]}, Origem: {origem[contadorB]}, Destino: {destino[contadorB]}, Data de vôo: {data[contadorB]}");
                    contadorB++;
                }
                break;
                case 0 :
                  Console.WriteLine("Obrigada por usar nosso sistema!");
                break;
    
                default:
                  Console.WriteLine("Opção Inválida!");
                break; 
            } // fim do menu (switch)

            }while (opcao !=0); //Enquanto a "Opcao" for diferente de 0 (!) (true), o laço se repete, quando for (false) sai.
            
            
        }
    }
}
