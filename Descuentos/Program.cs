internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            int price = 6500;
            double Number = 0;
            double Number1 = 0;
            Console.WriteLine("Precio de escritorio = $6500");
            Console.WriteLine("Número de escritorio: ");
            int sam = int.Parse(Console.ReadLine());
            if (sam < 5)
            {
                Number = price * sam;
                Number1 = Number * 0.1;
                Console.WriteLine($"${Number1} va a pagar");
            }
            if ((sam >= 5) && (sam < 10))
            {
                Number = price * sam;
                Number1 = Number * 0.2;
                Console.WriteLine($"${Number1} vas a pagar");
            }
            if (sam >= 10)
            {
                Number = price * sam;
                Number1 = Number * 0.4;
                Console.WriteLine($"${Number1} vas a pagar");
            }

        } while (true);
    }
}