namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          while (true)
            {


                Console.WriteLine("calculadora para consumo de combustivel");






                Console.Clear();
                Console.WriteLine("Digite a quilometragem inicial");
                string quilometrageminicial = "";
                quilometrageminicial=Console.ReadLine();
                double quilometrageminicial2 = Convert.ToDouble(quilometrageminicial);

                Console.WriteLine("Digite a quilometragem final");
                string quilometragemfinal = "";
                quilometragemfinal=Console.ReadLine();
                double quilometragemfinal2 = Convert.ToDouble(quilometragemfinal);
                
                Console.WriteLine("Digite o consumo de combustivel (em litros)");
                string consumomedio = "";
                consumomedio=Console.ReadLine();   
               double consumomedio2=Convert.ToDouble(consumomedio);




                double resultado = quilometrageminicial2 - quilometragemfinal2;
                double resultado2 = resultado / consumomedio2;


                Console.WriteLine("O consumo de combustivel medio foi" + resultado2);



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
