namespace LerValores.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, ler 3 valores e comparar se a soma do dois primeiros valores é menor que o terceiro valor");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar dos três valores:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o primeiro(A) valor");


                double valorUm = Double.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o segundo valor(B) ");


                double valorDois = Double.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o terceiro valor(C) ");


                double valorTres = Double.Parse(Console.ReadLine());

                
                double soma = valorUm + valorDois;

                if (soma < valorTres)
                {
                    Console.WriteLine("Na comparação dos três valores, a soma dos dois primeiros valores é MENOR que o terceiro valor.");
                    Console.WriteLine($"A soma do primeiro e segundo valor é: {soma}");
                }
                else
                {
                    Console.WriteLine("Na comparação dos três valores,  a soma dos dois primeiros valores é MAIOR que o terceiro valor.");
                }


                   
                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
