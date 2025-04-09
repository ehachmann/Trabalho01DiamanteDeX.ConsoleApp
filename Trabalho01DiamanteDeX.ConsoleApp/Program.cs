namespace Trabalho01DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        // Método para desenhar o Diamante de X
        static void Main(string[] args)
        {
            #region input
            Console.WriteLine("Método do Diamante de X");
            Console.WriteLine("OBS: O número deve ser ímpar e maior que 1");
            Console.Write("Digite o número: ");
            int numero = int.Parse(Console.ReadLine());
            #endregion

            //Verifica se o número é par e maior que 1
            if (numero % 2 == 0)
            {
                Console.WriteLine("Número inválido, digite um número ímpar.");
                return;
            }
            else if (numero < 1)
            {
                Console.WriteLine("Número inválido, digite um número maior que 1.");
                return;
            }
         
        }
    }
}

