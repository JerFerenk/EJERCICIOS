
    internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Ingrese primer numero: ");
            int name = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero: ");
            int name2 = int.Parse(Console.ReadLine());
            if (name % name2 == 0)
            {
                Console.WriteLine($"El numero {name2} es multiplo de {name}");
            }
            else
            {
                Console.WriteLine($"El numero {name2} no es multiplo de {name}");
            }
        } while (true);
            Console.ReadKey();
    }
}
