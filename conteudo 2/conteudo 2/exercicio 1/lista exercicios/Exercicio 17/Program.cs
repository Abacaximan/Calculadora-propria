using System.Reflection;

namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
                Console.Clear();

                Console.WriteLine("Escreva o primeiro valor (A)");
                string primeirovalor = "";
                primeirovalor = Console.ReadLine();
                double primeirovalor1 = Convert.ToDouble(primeirovalor);

                Console.WriteLine("Escreva o segundo valor (B)");
                string segundovalor = "";
                segundovalor = Console.ReadLine();
                double segundovalor1 = Convert.ToDouble(segundovalor);

                Console.WriteLine("Escreva o terceiro valor (C)");
                string terceirovalor = "";
                terceirovalor = Console.ReadLine();
                double terceirovalor1 = Convert.ToDouble(terceirovalor);


                double resultado1 = primeirovalor1 + segundovalor1;

                if (resultado1 > 0) {

                    Console.WriteLine("A soma dos dois primeiros valores e maior do que C, a soma total e " + resultado1);
                
                }

                if (resultado1 < 0)
                {


                    Console.WriteLine("A soma dos dois primeiros valores e menor do que C, a soma total e " + resultado1);



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
}
