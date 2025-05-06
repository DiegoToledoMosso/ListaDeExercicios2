namespace OrdemDecrescente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, Aqui iremos ler três valor e coloca-los em ordem decrescente.");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar dos três valores:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o primeiro(A) valor");


                int valorUm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o segundo valor(B) ");


                int valorDois = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o terceiro valor(C) ");


                int valorTres = Convert.ToInt32(Console.ReadLine());

                int[] numeros = { valorUm, valorDois, valorTres };

                bool troca = true;
                while (troca)
                {
                    troca = false;
                    for (int i = 0; i < numeros.Length - 1; i++)
                    {
                        if (numeros[i] < numeros[i + 1])
                        {
                            // Troca os elementos
                            int temp = numeros[i];
                            numeros[i] = numeros[i + 1];
                            numeros[i + 1] = temp;
                            troca = true;
                        }
                    }
                }

                // Imprime os números ordenados
                Console.WriteLine("Números em ordem decrescente:");
                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }



                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
            
        }
    }
}
