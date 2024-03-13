using System.Diagnostics;
using System.Reflection.Metadata;

namespace Calculadora_propria
{
    internal class Program
    {
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
                        if (operacao == "S")
                        {
                            break;
                        }
                        Console.WriteLine();

                        Console.WriteLine("Digite o primeiro numero");
                        string primeironumerostring = Console.ReadLine();
                        int primeironumero = Convert.ToInt32(primeironumerostring);


                        Console.WriteLine("digite o segundo numero");
                        string segundonumerostring = Console.ReadLine();
                        int segundonumero = Convert.ToInt32(segundonumerostring);


                        int resultado = 0;

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

                            if (segundonumero <= 0 || primeironumero <= 0)
                            {

                                Console.Clear();
                            }


                            resultado = primeironumero / segundonumero;
                            Console.WriteLine("todo numero dividido por 0 e igual a zero");
                            Console.WriteLine("Aperte enter para voltar ao inicio");

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

