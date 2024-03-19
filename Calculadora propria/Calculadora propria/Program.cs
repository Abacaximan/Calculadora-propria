using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace Calculadora_propria
{
    internal class Program
    {
        private static double segundoNumero;

        static void Main(string[] args)
        {

            while (true)
            {
                string operacao = mostrarmenu();

                if (opcaodesaidaselecionada(operacao))
                    break;

                #region codigo 
                {
                    if (operacao != "S" && operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "s")
                    {
                        Console.WriteLine("informe uma operacao valida");
                        Console.ReadLine();
                        continue;
                    }
                    else if (operacao == "S" || operacao == "s")
                    {
                        break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Digite o primeiro numero");

                    double primeironumero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero");

                    double segundonumero = Convert.ToDouble(Console.ReadLine());
                    double resultado = 0;

                    if (operacao == "1")
                    {
                        resultado = primeironumero + segundonumero;
                    }
                    else if (operacao == "2")
                    {
                        resultado = primeironumero - segundonumero;
                    }
                    else if (operacao == "3")
                    {
                        while (segundonumero == 0)
                        {
                            Console.WriteLine("Digite um numero maior que zero");

                            segundonumero = Convert.ToDouble(Console.ReadLine());
                        }
                        resultado = primeironumero / segundonumero;
                    }
                    else if (operacao == "4")
                    {
                        resultado = primeironumero * segundonumero;
                    }
                    Console.WriteLine("o resultado e " + resultado);
                    Console.ReadLine();
                    #endregion

                }
            }
        }
        static string mostrarmenu()
        {


            Console.Clear();

            Console.WriteLine("Calculadora propria\n");

            Console.WriteLine("Digite 1 para adicionar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para dividir");
            Console.WriteLine("digite 4 para multiplicar");
            Console.WriteLine("Digite S se quiser sair");

            string operacao = Console.ReadLine();

            return operacao;

        }

        static bool opcaodesaidaselecionada(string opcao)
        {

            bool opcaosaida1 = opcao == "S" || opcao == "s";


            return opcaosaida1;

        }


    
    }
}