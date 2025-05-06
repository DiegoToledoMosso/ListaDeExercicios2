using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ParOuIMpar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos checar se o número fornecido é par ou ímpar.");
                Console.WriteLine("--------------------------------------------------");

                
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o número inteiro desejado.");


                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número {0} é par.", numero);
                }
                else 
                {
                    Console.WriteLine("O número {0} é ímpar.", numero);
                }
                

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
