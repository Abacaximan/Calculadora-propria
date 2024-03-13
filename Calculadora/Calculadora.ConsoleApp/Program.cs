using System.Diagnostics;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("digite 1 para Adicionar");
                Console.WriteLine("digite 2 para subtrair");
                Console.WriteLine("digite 3 para multiplicar");
                Console.WriteLine("digite 4 para dividir");


                Console.WriteLine("digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S")
                {
                    break;
                }

                Console.WriteLine("digite o primeiro numero");

                string primeironumeroString = Console.ReadLine();
                int primeironumero = Convert.ToInt32(primeironumeroString);

                Console.WriteLine(primeironumeroString);

                Console.WriteLine("digite o segundo numero");

                string segundonumeroString = Console.ReadLine();
                int segundonumero = Convert.ToInt32(segundonumeroString);


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

                    resultado = primeironumero * segundonumero;
                }
                else if (operacao == "4")
                {

                    resultado = primeironumero / segundonumero;
                }



                Console.WriteLine("o resultado e:  " + resultado);

                Console.ReadLine();


                Console.WriteLine("voce deseja sair (S/N)");

                string resposta = Console.ReadLine();







            }
        }
    }
}



