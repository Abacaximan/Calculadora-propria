namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();

                Console.WriteLine("Calculadora de diametro de uma esfera");



                Console.WriteLine("digite o diametro da esfera");
                string diametro = "";
                diametro = Console.ReadLine();
                double diametro2 = Convert.ToDouble(diametro);

                double resultado2 = Math.Pow(diametro2, 3);

                double resultado1 = (4 / 3) * 3.14;

                double resultado3 = resultado1 * resultado2;

                Console.WriteLine("O diametro e:" + resultado3);


                Console.WriteLine("Digite S para sair e N para voltar ao inicio");

                //nao consegui acertar a operaçao para o diametro da esfera.



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
