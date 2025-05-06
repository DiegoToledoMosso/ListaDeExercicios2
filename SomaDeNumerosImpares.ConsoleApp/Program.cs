namespace SomaDeNumerosImpares.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int numero = 1; numero <= 500; numero++)
            {
                if (numero % 2 != 0)
                {
                    if(numero % 3 == 0)

                        soma = soma + numero;
                }

            }

            Console.WriteLine($"O resultado da soma é: "+ soma);
            Console.ReadKey();
        }
    }
}
