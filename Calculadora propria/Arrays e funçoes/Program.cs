using System.Linq;
using System.Numerics;

namespace Arrays_e_funçoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;


            int[] numeros = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };

            int valormaximo = numeros.Max();

            Console.WriteLine(valormaximo);
            Console.ReadLine();

            int valorminimo = numeros.Min();
            Console.WriteLine(valorminimo);
            Console.ReadLine();

            double medio = numeros.Average();
            Console.WriteLine(medio);
            Console.ReadLine();

            Array.Sort(numeros);
            Array.Reverse(numeros);

            var tresmaiores = numeros.Take(3);


            Console.WriteLine("Os tres maiores valores sao: ");

            foreach (var valor in tresmaiores)
            {
               
                Console.Write( valor + " ");
                
            }

            Console.ReadLine( );











        }    

    }
 
}

