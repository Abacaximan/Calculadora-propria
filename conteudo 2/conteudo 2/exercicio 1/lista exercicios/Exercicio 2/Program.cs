namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
           Console.Clear();

                Console.WriteLine("conversora de temperatura Fahrenheit para Celsius");

                Console.WriteLine("escreva a temperatura em Fahrenheit");

                string temperatura1 = "";

                temperatura1 = Console.ReadLine();
                double temperaturaF = Convert.ToDouble(temperatura1);


                double resultado1 = temperaturaF - 32;

                double resultado2 = resultado1 / 1.8;


                Console.WriteLine("A temperatura em Celsius e:" + resultado2);


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


        
