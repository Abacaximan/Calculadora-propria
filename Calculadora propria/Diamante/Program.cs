Console.ForegroundColor = ConsoleColor.Red;
while (true)
{
    #region imput
    Console.Clear();

    Console.WriteLine("digite um numero impar para formar o diamante");

    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine("Digite um numero impar");
        Console.ReadLine();
    }
    #endregion
    #region topo do diamante
    else
    {
        int espaçosdiamante = numero / 2;
        int X = 1;
        for (int i = 0; i < (numero / 2) + 1; i++)
        {
            Console.Write(new string(' ', espaçosdiamante));
            Console.WriteLine(new string('X', X));

            espaçosdiamante--;

            X += 2;
        }
        #endregion
        #region dados para formaçao
        espaçosdiamante = 1;
        X = numero - 2;
        #endregion
        #region Parte de baixo
        for (int i = (numero / 2); i > 0; i--)
        {

            Console.Write(new string(' ', espaçosdiamante));
            Console.WriteLine(new string('X', X));
            espaçosdiamante++;
            X -= 2;
        }

        Console.WriteLine("Digite S para sair e N para voltar ao inicio");

        String sair = Console.ReadLine();
        #endregion
        #region Saida ou reset do progama
        if (sair == "S")
        {

            break;

        }
        if (sair == "N")
        {

            continue;
        }
        #endregion
    }
}
