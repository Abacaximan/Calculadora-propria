namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("digite um numero impar para formar o diamante");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Digite um numero impar");

            }
            else
            {

                int espaçosdiamante = numero / 2;

                int X = 1;

                for (int i = 0; i < (numero / 2) + 1; i++)
                {

                    Console.Write(new string (' ', espaçosdiamante));
                    Console.WriteLine(new string('X',X));

                    espaçosdiamante--;
                    
                    X+=2;

                }

                espaçosdiamante = 1;
                X = numero - 2;

                for (int i = (numero / 2); i > 0; i--)
                {


                    Console.Write(new string(' ', espaçosdiamante));
                    Console.WriteLine(new string('X', X));
                    espaçosdiamante++;
                    X -= 2;


                }

                Console.ReadLine();


            }
        }
    }
}               
