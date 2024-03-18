namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
         while (true)
            {

                Console.WriteLine("Calculadora de quantos dias voce ja viveu");

                Console.Clear();
                Console.WriteLine("Qual e seu nome ?");
                string nome = "";
                nome = Console.ReadLine();

                Console.WriteLine("Qual e sua idade ?");
                string idade = "";
                idade= Console.ReadLine();
                double idadenumero = Convert.ToDouble(idade);

                double resultadoidade = idadenumero * 365;


                Console.WriteLine(nome + " voce ja viveu " + resultadoidade + " Dias");


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
