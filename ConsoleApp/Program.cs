namespace NumerosImpares.ConsoleApp;

    
    internal class Program
    {
        static void Main(string[] args)
        {

        // Iterar de 100 a 200
        for (int numero = 100; numero <= 200; numero++)
        {
            // Verificar se o número é ímpar (o resto da divisão por 2 é diferente de 0)
            if (numero % 2 != 0)
            {
                // Se for ímpar, imprimir o número
                Console.WriteLine(numero);
            }
        }
        Console.ReadLine(); 


    }
    }

 
