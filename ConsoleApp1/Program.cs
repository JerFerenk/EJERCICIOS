// See https://aka.ms/new-console-template for more information
Console.WriteLine("Número es PAR o IMPAR");

        int number = 0;
    do
	{

    Console.Write("Ingrese un numero: ");
        number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("Es par");
        else
             Console.WriteLine("Es impar");

    Console.WriteLine("\nPresiona enter para continuar o Ctr + C para finalizar\n");
    Console.ReadKey();

    } while (true);
        