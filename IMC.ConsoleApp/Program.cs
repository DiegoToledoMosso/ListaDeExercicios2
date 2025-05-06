namespace IMC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, Bem-vindo a calculadores de Índice de Massa Corporal(IMC).");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Para começar, irei precisar saber o seu peso(em Kg) e sua altura(em metros).:");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Por favor informe seu peso usando a virgula.");


                float peso = float.Parse(Console.ReadLine());

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Por favor informe sua altura usando a virgula.");


                float altura = float.Parse(Console.ReadLine());


                float imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.WriteLine($"O Valor do seu IMC e de : {imc}");
                    Console.WriteLine("Está abaixo do peso.");
                }

                else if (imc > 18.5 && imc < 25)
                {
                    Console.WriteLine($"O Valor do seu IMC e de : {imc}");

                    Console.WriteLine("Está no peso normal.");
                }

                else if (imc > 25 && imc < 30)
                {
                    Console.WriteLine($"O Valor do seu IMC e de : {imc}");

                    Console.WriteLine("Está acima do peso.");
                }
                    

                else if (imc > 30)
                {
                    Console.WriteLine($"O Valor do seu IMC e de : {imc}");

                    Console.WriteLine("Está obeso.");
                }
                                              




                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
