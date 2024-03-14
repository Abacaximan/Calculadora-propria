using System.Reflection.Metadata;

namespace exercicio01.console.app
{
    internal class Program
    {
        static void Main(string[] args)
        {

          while (true) {
                Console.Clear();

           Console.WriteLine("Digite o comprimento do retangulo");

                string primeirodadostring = "";

            primeirodadostring = Console.ReadLine();
           double comprimento = Convert.ToDouble(primeirodadostring);

                Console.WriteLine("Digite a largura");
                string segundodadostring = "";
                segundodadostring = Console.ReadLine();
                double largura = Convert.ToDouble(segundodadostring);
            Console.WriteLine("Digite a altura");
                string terceirodadostring = "";
                terceirodadostring = Console.ReadLine();
                double altura = Convert.ToDouble(terceirodadostring);
                double resultado = 0;
                if (altura > 0) { 
                resultado = comprimento * largura * altura;
                }
                Console.WriteLine("o volume da caixa retangular e:" + resultado);
                Console.WriteLine("Digite S para sair e N para voltar ao inicio");
                String sair = Console.ReadLine();
                if (sair == "S")
                {
                    break;
                }
                if (sair == "N")
                {
                    continue;


                }                              }
        }
    }
}
