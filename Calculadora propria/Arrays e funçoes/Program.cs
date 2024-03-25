using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Arrays_e_funçoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;


            int[] numeros = new int[] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6 };           
            int valormaximo = numeros.Max();
          


            Console.WriteLine("A sequencia dos numeros em ordem Decrescente E: ");

            Array.Sort(numeros);
            Array.Reverse(numeros);

            foreach (var sequencia in numeros)
            {
                Console.Write(sequencia + " ");

            }

            Console.ReadLine();

            Console.WriteLine("O valor maximo da sequencia e: ");
            Console.WriteLine(valormaximo);
            Console.ReadLine();

            Console.WriteLine("O valor minimo da sequencia e: ");
            int valorminimo = numeros.Min();
            Console.WriteLine(valorminimo);
            Console.ReadLine();

            Console.WriteLine("O valor medio da sequencia e: ");
            double medio = numeros.Average();
            Console.WriteLine(medio);
            Console.ReadLine();



            var tresmaiores = numeros.Take(3);


            Console.WriteLine("Os tres maiores valores sao: ");

            foreach (var valor in tresmaiores)
            {
               
                Console.Write( valor + " ");
                
            }
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Os numeros negativos sao: ");
            for (int i = 0;i < numeros.Length;i++)
            {

                if (numeros[i] < 0)
                {
                   
                    Console.WriteLine($"{numeros[i] + ""}");


                }               
            }
            Console.ReadLine();

            
           







        }    
    }

}

