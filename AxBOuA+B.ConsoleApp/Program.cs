namespace AxBOuA_B.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos ler dois valores inteiros, se eles forem iguais iremos soma-los, caso contrário iremos multiplica-los");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar dos dois valores:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o primeiro(A) valor");


                int valorUm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("digite o segundo valor(B) ");


                int valorDois = Convert.ToInt32(Console.ReadLine());


                var valorFinal = 0;

                if (valorUm == valorDois)
                {
                    valorFinal = valorUm + valorDois;
                    Console.WriteLine("Os números são iguais, então a soma deles é :" + valorFinal);
                }
                else
                {
                    valorFinal = valorUm * valorDois;
                    Console.WriteLine("Os números são diferentes, então a multiplicação deles é :" + valorFinal);
                }





                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
