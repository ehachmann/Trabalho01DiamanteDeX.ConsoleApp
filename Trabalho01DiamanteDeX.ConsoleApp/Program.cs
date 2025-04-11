using System.Runtime.CompilerServices;

namespace Trabalho01DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        // Refatoração do código para melhorar a legibilidade
        static void Main(string[] args)
        {
            // Variável para controle de repetição

            string numeroinvalido = "S";

            while (numeroinvalido == "S")
            {
                Console.Clear();

                // Entrada de dados
                Console.WriteLine("============================================="); 
                Console.WriteLine("          Método do Diamante de X");
                Console.WriteLine(" OBS: O número deve ser ímpar e maior que 1");
                Console.WriteLine("=============================================");
                Console.WriteLine();
                Console.Write("Digite o número: ");
                int numero = int.Parse(Console.ReadLine());

                int meio = numero / 2;
                int espaco = numero / 2;
            
                //Verifica se o número é par e maior que 1

                if (numero <= 1)
                {
                    Console.WriteLine(); 
                    Console.WriteLine("Número inválido, digite um número maior que 1 !!!");
                    Console.ReadKey();
                    continue;
                }
                else if (numero % 2 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Número inválido, digite um número ímpar !!!");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine();

                // Chama função para desenhar a parte superior do diamante
                ParteSuperior(meio, espaco);

                // Chama função para desenhar a parte inferior do diamante
                ParteInferior(meio, espaco);

             Console.WriteLine();
             Console.Write("Digitar novamente? (S/N): ");
             string opcaoContinuar = Console.ReadLine().ToUpper();

             Console.Clear();
             if (opcaoContinuar != "S")
                 break;
            }
        }

        // Desenha a parte superior do diamante
        static void ParteSuperior(int meio, int espaco)
        {
            for (int i = 0; i <= meio; i++)
            {
                for (int j = espaco; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                espaco--;
                for (int j = 1; j <= (2 * i + 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Desenha a parte inferior do diamante
        static void ParteInferior(int meio, int espaco)
        {
            espaco = 1;
            for (int i = meio; i >= 0; i--)
            {
                for (int j = espaco; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                espaco++;
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


