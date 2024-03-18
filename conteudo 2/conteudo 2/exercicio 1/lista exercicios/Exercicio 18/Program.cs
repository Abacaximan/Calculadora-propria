namespace Exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            
            Console.Clear();



                Console.WriteLine("Escreva o primeiro valor");
                string primeirovalor = "";
                primeirovalor = Console.ReadLine();          
            double primeirovalor1 = Convert.ToDouble(primeirovalor);

                Console.WriteLine("Escreva o segundo valor");
                string segundovalor = "";
                segundovalor = Console.ReadLine();
                double segundovalor1 = Convert.ToDouble(segundovalor);

                Console.WriteLine("Escreva o terceiro valor");
                string terceirovalor = "";
                terceirovalor = Console.ReadLine();
                double terceirovalor1 = Convert.ToDouble(terceirovalor);

                while (primeirovalor1 < segundovalor1 || primeirovalor1 == terceirovalor1)
                {
                    Console.WriteLine("Digite um numero maior que zero");
                   
                    segundovalor1 = Convert.ToDouble(Console.ReadLine());
                    terceirovalor1=Convert.ToDouble(Console.ReadLine());

                }


                double resultado = 


                    //Nao consegui pensar em como fazer esse mecanismo de diferenciaçao de numeros




            }



        }
    }
}
