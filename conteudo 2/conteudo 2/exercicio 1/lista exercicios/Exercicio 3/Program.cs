namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
while (true) {
                Console.Clear();
                Console.WriteLine("calculadora para volume de um cilindro");

            Console.WriteLine("Digite o raio do cilindro");

            string raio = "";

          raio = Console.ReadLine();
            double raio2 = Convert.ToDouble(raio);

            Console.WriteLine("Digite a altura do cilindro");
            string altura = "";

            altura = Console.ReadLine();
            double altura2 = Convert.ToDouble(altura);


            double resultado1 = raio2 * 2 * 3.14;
            double resultado2 = resultado1 * altura2;


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
