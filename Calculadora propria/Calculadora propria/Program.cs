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
                Console.Clear();

                Console.WriteLine("Calculadora propria");

                Console.WriteLine("Digite 1 para adicionar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para dividir");
                Console.WriteLine("digite 4 para multiplicar");
                Console.WriteLine("Digite S se quiser sair");


                string operacao = Console.ReadLine();

                             {


                    if (operacao != "S" && operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "s")
                    {

                        Console.WriteLine("informe uma operacao valida");
                        Console.ReadLine();
                        continue;


                    }

                    else if (operacao == "S")
                    {
                        break;
                    }

                                  

                        Console.WriteLine();

                        Console.WriteLine("Digite o primeiro numero");
                        string primeironumerostring = Console.ReadLine();
                         double primeironumero = Convert.ToDouble(primeironumerostring);

                    Console.WriteLine("digite o segundo numero");
                        string segundonumerostring = Console.ReadLine();
                        double segundonumero = Convert.ToDouble(segundonumerostring);


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

                    }
                }

            }

        }
    }

