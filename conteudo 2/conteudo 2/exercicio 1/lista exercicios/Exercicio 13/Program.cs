namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true) { 
            
                Console.Clear();





                Console.WriteLine("digite a quantidade de paes que foram vendidos no dia");
                string quantidadepaes = "";
                quantidadepaes=Console.ReadLine();
                double quantidadepaes1 = Convert.ToDouble(quantidadepaes);

                Console.WriteLine("Digite a quantia de broas que foram vendidas no dia");
                string quantidadebroas = "";
                quantidadebroas=Console.ReadLine();
                double quantidadebroas1=Convert.ToDouble(quantidadebroas);

                double resultadopaes = quantidadepaes1 * 0.12;
                double resultadobroas= quantidadebroas1*1.5;

                double arrecadacao =  resultadopaes + resultadobroas;
                double poupanca = arrecadacao * 0.1;
                 
                Console.WriteLine("a sua arrecadacao do dia foi " + arrecadacao);
                Console.WriteLine("deve ser investido esta quantia na poupanca "+ poupanca);
                
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
