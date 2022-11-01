internal class Program
{
    static void Main(string[] args)
    {
        double mom;
        string dad;
        Console.WriteLine("Ingresar su nombre");
        dad = Console.ReadLine();
        Console.WriteLine("Ingresar los puntos");
        mom = Double.Parse(Console.ReadLine());

        Comparacion(mom, dad);
        Console.ReadLine();
    }

    static void Comparacion(double punt, string nom)
    {
        double mat = 9993.7;
        string mat2 = "Samuel";

        if (mat < punt)
        {
            Console.WriteLine($"{nom} Es la persona que supero el record");
            Console.WriteLine($"Superando a {mat2}");
            Console.WriteLine($"Con los puntos: {punt}");
        }
        else
        {
            Console.WriteLine($"{mat2} Es la persona que aun tiene el puntaje record");
            Console.WriteLine($"{mat} Sigue siendo la mejor puntuacion");
        }
    }
}