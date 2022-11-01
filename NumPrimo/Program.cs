internal class Program
{
    static void Main(string[] args)
    {
        int CONTADOR = 2;
        int Contador1 = 0;
        int alt;

        Console.Write("Ingrese el numero:");
        int number = int.Parse(Console.ReadLine());

        while (CONTADOR < number && Contador1 == 0)
        {
            alt = number % CONTADOR;
            if (alt == 0)
            {
                Contador1 = 1;
            }
            else
            {
                CONTADOR = CONTADOR + 1;
            }
        }
        if (Contador1 == 0)
        {
            Console.WriteLine($"El numero {number} es primo");
        }
        else
        {
            Console.WriteLine($"El numero {number} no es primo");
        }
        Console.ReadKey();
    }
}
