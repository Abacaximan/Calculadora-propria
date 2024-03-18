namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {

                Console.WriteLine("Calculadora de salario com base em um aumento de 15% ");

                Console.Clear();
                Console.WriteLine("Digite o seu salario");
                string salario = "";
                salario = Console.ReadLine();
                double salario1 = Convert.ToDouble(salario);

                double resultadoaumento = 0.15 * salario1;
                double resultadoaumentosalario = salario1 + resultadoaumento;

                double resultadofinal = salario1+ resultadoaumento - 0.08 * salario1;

                Console.WriteLine("Seu salario inicial e de " + salario1 + " seu salario final e " + resultadofinal + " e seu salario com aumento e de "+ resultadoaumentosalario);
                 
                Console.WriteLine(" Digite S para sair e N para voltar ao inicio ");

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

