using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        #region algoritmo
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Digite quantos números deseja inserir na sequência:");
        int count = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[count];

        Console.WriteLine($"Digite {count} números:");

        for (int i = 0; i < count; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Valor Máximo");
            Console.WriteLine("2 - Valor Mínimo");
            Console.WriteLine("3 - Valor Médio");
            Console.WriteLine("4 - Os Três Maiores Valores");
            Console.WriteLine("5 - Números Negativos");
            Console.WriteLine("6 - Sequência em Ordem Decrescente");
            Console.WriteLine("7 - Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    maximum(numeros);
                    break;
                case 2:
                    minimum(numeros);
                    break;
                case 3:
                    medium(numeros);
                    break;
                case 4:
                    maiores(numeros);
                    break;
                case 5:
                    negativos(numeros);
                    break;
                case 6:
                    numerais(numeros);
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
    #endregion
    #region Funções

    static void maximum(int[] numeros)
    {
        int valormaximo = numeros.Max();
        Console.WriteLine("O valor máximo da sequência é: ");
        Console.WriteLine(valormaximo);
        Console.ReadLine();
    }

    static void minimum(int[] numeros)
    {
        Console.WriteLine("O valor mínimo da sequência é: ");
        int valorminimo = numeros.Min();
        Console.WriteLine(valorminimo);
        Console.ReadLine();
    }

    static void medium(int[] numeros)
    {
        Console.WriteLine("O valor médio da sequência é: ");
        double medio = numeros.Average();
        Console.WriteLine(medio);
        Console.ReadLine();
    }

    static void maiores(int[] numeros)
    {
        var tresmaiores = numeros.OrderByDescending(x => x).Take(3);
        Console.WriteLine("Os três maiores valores são: ");
        foreach (var valor in tresmaiores)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }

    static void negativos(int[] numeros)
    {
        Console.WriteLine("Os números negativos são: ");
        foreach (var num in numeros)
        {
            if (num < 0)
            {
                Console.WriteLine(num);
            }
        }
        Console.ReadLine();
    }

    static void numerais(int[] numeros)
    {
        Console.WriteLine("A sequência dos números em ordem decrescente é: ");
        Array.Sort(numeros);
        Array.Reverse(numeros);
        foreach (var sequencia in numeros)
        {
            Console.Write(sequencia + " ");
        }
        Console.ReadLine();
    }

    #endregion
}