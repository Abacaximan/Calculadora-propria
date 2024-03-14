namespace Exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();


                Console.WriteLine("escreva a temperatura em celsius");

                string temperatura1 = "";

                temperatura1 = Console.ReadLine();
                double temperaturaC = Convert.ToDouble(temperatura1);


                double resultado1 = temperaturaC * 1.8 ;

                double resultado2 = resultado1 + 32;


                Console.WriteLine("A temperatura em Fahrenheit e:" + resultado2);


                Console.WriteLine("Digite S para sair e N para voltar ao inicio");

                String sair = Console.ReadLine();
                if (sair == "S")
                {

                    break;

                }
                if (sair == "N")
                {

                    continue;


                }
            }
        }
   }
    }

