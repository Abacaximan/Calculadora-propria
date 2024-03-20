using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace Exercicio_19
{
    internal class Program
    {
        private static double lturaM1;

        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Informe sua altura em metros\n");
                double altura=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Informe seu peso\n");
                double peso=Convert.ToDouble(Console.ReadLine());

                double imc = peso / (altura*altura);


                if (imc <= 18.5)
                {

                    Console.WriteLine("seu imc e igual a: " + imc + " voce esta abaixo do peso ideal");


                }

                if (imc >= 18.5 && imc <= 25)
                {


                    Console.WriteLine("seu imc e igual a: " + imc + " voce esta no peso ideal");


                }
                if (imc > 25 && imc <= 30)
                {


                    Console.WriteLine("seu imc e igual a: " + imc + " voce esta acima do peso");

                }

                if (imc > 30)
                {

                    Console.WriteLine("Seu imc e igual a: " + imc + "voce esta com obesidade");
   

                }


                Console.WriteLine(" Digite S para sair e N para voltar ao inicio ");

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
