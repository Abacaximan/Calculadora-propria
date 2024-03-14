namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Digite o raio da lata de oleo");

                string raio = "";

                raio = Console.ReadLine();
                double raio2 = Convert.ToDouble(raio);

                Console.WriteLine("Digite a altura da lata de oleo");
                string altura = "";

                altura = Console.ReadLine();
                double altura2 = Convert.ToDouble(altura);


                double resultado1 = Math.Pow(raio2, 2);
                double resultado3 = resultado1 * 3.14;
                double resultado2 = resultado3 * altura2;


                Console.WriteLine("o volume do cilindro e:" + resultado2);


                Console.WriteLine("Digite S para sair e N para voltar ao inicio");

                String sair = Console.ReadLine();
                if (sair == "S")
                {

                    break;

                }
                if (sair == "N")
                {

                    continue;


                }




            }
        }
    }
}