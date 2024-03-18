using System.ComponentModel.Design;

namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Calculadora de IMC");
                Console.Clear();
                Console.WriteLine("Informe seu peso (Em KG)");
                string pesokg = "";
                pesokg = Console.ReadLine();
                double pesokg1 = Convert.ToDouble(pesokg);

                Console.WriteLine("Informe sua altura (Em metros)");
                string alturaM = "";
                alturaM = Console.ReadLine();
                double alturaM1 = Convert.ToDouble(alturaM);

                double resultado1 = alturaM1 * alturaM1;
                double resultadoIMC = resultado1 / pesokg1;

                if (resultadoIMC <= 18.5)
                {

                    Console.WriteLine("Voce esta abaixo do peso. o IMC para abaixo do peso medio e 18.5 " + resultadoIMC);

                }


                else if (resultadoIMC <= 30)
                {



                    Console.WriteLine("Voce esta Obeso. o IMC para pessoas Obesas e de 30 " + resultadoIMC);


                }



                else if (resultadoIMC >= 18.5 || resultadoIMC <= 25)
                {

                    Console.WriteLine("Voce esta na faixa de peso ideal. " + resultadoIMC);

                }

                else if (resultadoIMC >= 25 || resultadoIMC > 30)
                {

                    Console.WriteLine("voce esta acima do peso. o IMC para pessoas acima do peso e " + resultadoIMC );


                }

                //Tambem nao consegui acertar a formula para o IMC.

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
