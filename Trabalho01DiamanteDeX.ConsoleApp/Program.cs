using System.Runtime.CompilerServices;

namespace Trabalho01DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        // Loop de validação se o número é par ou menor que 1
        static void Main(string[] args)
        {
            // Variável para controle de repetição
            string numeroinvalido = "S";

            while (numeroinvalido == "S")
            { 

                // Entrada de dados
                Console.WriteLine("Método do Diamante de X");
                Console.WriteLine("OBS: O número deve ser ímpar e maior que 1");
                Console.Write("Digite o número: ");
                int numero = int.Parse(Console.ReadLine());

                int meio = numero / 2;
                int espaco = numero / 2;
            
                //Verifica se o número é par e maior que 1
                if (numero <= 1)
                {
                    Console.WriteLine(); 
                    Console.WriteLine("Número inválido, digite um número maior que 1 !!!");
                }
                else if (numero % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Número inválido, digite um número ímpar !!!");
                }


             Console.Write("Digitar novamente? (S/N): ");
             string opcaoContinuar = Console.ReadLine().ToUpper();

             Console.Clear();
             if (opcaoContinuar != "S")
                 break;
            }
        }
    }
}


