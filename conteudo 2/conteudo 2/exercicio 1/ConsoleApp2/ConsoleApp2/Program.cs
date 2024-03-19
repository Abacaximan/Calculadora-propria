using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de termos da sequência de Fibonacci que deseja gerar:");
            if (decimal.TryParse(Console.ReadLine(), out var qtdTermos))
            {
                var primeiroTermo = 1;
                var segundoTermo = 1;

                if (qtdTermos <= 0)
                {
                    Console.WriteLine("Coloque apenas números acima de zero.");
                }
                if (primeiroTermo >= 1)
                {
                    Console.WriteLine(primeiroTermo + " ");
                }
                if (segundoTermo >= 2)
                {
                    Console.WriteLine(segundoTermo + " ");
                }
                else
                {

                    for (var i = 3; i < qtdTermos; i++)
                    {
                        var proximoTermo = primeiroTermo + segundoTermo;
                        Console.WriteLine(proximoTermo);

                        primeiroTermo = segundoTermo;
                        segundoTermo = proximoTermo;
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Operação Inválida.");
            }

            Console.ReadKey();
        }
    }
}
