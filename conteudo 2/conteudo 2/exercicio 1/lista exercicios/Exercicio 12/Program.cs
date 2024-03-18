namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
          while (true)
            {

                Console.Clear();

                Console.WriteLine("Calculadora para Area total do terreno");

                Console.WriteLine("Calculadora para area de terreno");


                Console.WriteLine("informe o comprimento do terreno");
                string comprimentoterreno1 = "";
                comprimentoterreno1 = Console.ReadLine();
                double areadoterreno = Convert.ToDouble(comprimentoterreno1);

                Console.WriteLine("informe a largura do terreno ");
                string larguradoterreno1 = "";
                larguradoterreno1 = Console.ReadLine();
                double larguradoterreno = Convert.ToDouble(larguradoterreno1);

                double resultado1 = areadoterreno * larguradoterreno;


             Console.WriteLine("a area do terreno e:" +  resultado1 +"M");


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
