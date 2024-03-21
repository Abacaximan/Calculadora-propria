using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Metadata;

namespace Calculadora_propria
{
    internal class Program
    {
        private static double segundoNumero;

        static void Main(string[] args)
        {
            #region Algoritmo
            while (true)
            {
                string operacao = mostrarmenu();

                if (opcaodesaidaselecionada(operacao))
                    break;


                if (opcaoinvalida(operacao))
                {

                    mensagemdeerro();
                    continue;

                }


                else realizarcalculo(operacao);

            }
        }
        #endregion

        #region Codigo
        static void mensagemdeerro()
        {

            Console.WriteLine("Digite uma opcao valida");

            Console.ReadLine();

        }

        static string mostrarmenu()
        {

            Console.Clear();

            Console.WriteLine("Calculadora propria\n");

            Console.WriteLine("Digite 1 para adicionar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para dividir");
            Console.WriteLine("digite 4 para multiplicar");
            Console.WriteLine("Digite 5 para fazer a tabuada\n");
            Console.WriteLine("Digite S se quiser sair");

            string operacao = Console.ReadLine();
            return operacao;
        }
        static bool opcaodesaidaselecionada(string opcao)
        {
            bool opcaosaida1 = opcao == "S" || opcao == "s";
            return opcaosaida1;
        }
        static bool opcaoinvalida(string opcao)
        {
            bool opcaoinvalida1 = opcao != "S" && opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "s" && opcao != "5";
            return opcaoinvalida1;
        }
        static void realizarcalculo(string operacao)
        {
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro numero");
            double primeironumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            double segundonumero = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;
            switch (operacao)
            {
                case "1":
                    resultado = primeironumero + segundonumero; break;
                case "2":
                    resultado = primeironumero - segundonumero; break;
                case "4":
                    resultado = primeironumero * segundonumero; break;
                case "3":
                    while (segundonumero == 0)
                    {
                        Console.WriteLine("Digite um numero maior que zero");

                        segundonumero = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = primeironumero / segundonumero;

                    break;

            }
            Exibirresultado(resultado);
        }
        private static void Exibirresultado(double resultado)
        {
            Console.WriteLine("o resultado e " + resultado);
            Console.ReadLine();
        }
        static void gerartabuada(string operacao) { 
        

             if (operacao == "5")
            {
                Console.Clear();

                Console.WriteLine("digite um numero inteiro");

                int numerodigitado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"tabuada do numero {numerodigitado}");
                Console.WriteLine();

                for (int i = 0; i < 11; i++)
                {



                    Console.WriteLine($"{numerodigitado} x {i}");

                }

                Console.ReadLine();
            }

        }
        #endregion


    }
}


 