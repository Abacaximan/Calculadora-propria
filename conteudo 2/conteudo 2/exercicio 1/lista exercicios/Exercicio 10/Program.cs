namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            
              Console.Clear();

                Console.WriteLine("calculadora ponderada");


                Console.WriteLine("digite o peso dessa prova");
                string peso1 = "";
                peso1 = Console.ReadLine();
                double pesodouble =Convert.ToDouble(peso1);

                Console.WriteLine("digite a nota que tirou na primeira prova");
                string nota1 = "";
                nota1 = Console.ReadLine();
            double notadouble = Convert.ToDouble(nota1);

                Console.WriteLine("Digite o peso da segunda prova");
                string peso2 = "";
                peso2 = Console.ReadLine();
                double pesodouble2= Convert.ToDouble(peso2);

                Console.WriteLine("Digite a nota que tirou na segunda prova");
                string nota2 = "";
                nota2 = Console.ReadLine();
                double notadouble2 =Convert.ToDouble(nota2);


                double pesoresultado1 = pesodouble2 + pesodouble;
                double notaresultado1 = pesodouble * notadouble;
                double notaresultado2 = pesodouble2 * notadouble2;
                double notaresultado3 = notaresultado1 + notaresultado2;
                double resultadogeral = notaresultado3 / pesoresultado1;

                Console.WriteLine("a media ponderada de suas provas e" + resultadogeral);




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
