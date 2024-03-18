namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();


                Console.WriteLine("Calculadora de salario + comissao");




                Console.WriteLine("Informe seu salario base");
                String salariobase = "";
                salariobase = Console.ReadLine();
                double salariobase2 = Convert.ToDouble(salariobase);

                Console.WriteLine("Informe sua comissao por base do numero de vendas");
                string comissao = "";
                comissao = Console.ReadLine();
                    double comissao2=Convert.ToDouble(comissao); 

                Console.WriteLine("Informe seu total de vendas do mes");
                string totaldevendas = "";
                totaldevendas = Console.ReadLine();
                double totaldevendas2 = Convert.ToDouble(totaldevendas);

                double resultado1 = totaldevendas2 * comissao2 / 100;
                double resultado2 = resultado1 + salariobase2;
                Console.WriteLine("Seu salario total e:"+ resultado2);

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
