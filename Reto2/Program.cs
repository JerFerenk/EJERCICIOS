    internal class Program
{
    static void Main(string[] args)
    {
        string temperatura = "";
        int combi = 0;
        string mensajes = "";
        do
        {
            //Igresamos la temperatura
            Console.WriteLine("Ingrese la temperatura:");
            temperatura = Console.ReadLine();
            bool val = int.TryParse(temperatura, out combi);
            if (val == true)
            {
                mensajes = combi <= 15 ? "Hace mucho frio" : "";
                Console.WriteLine(mensajes);
                mensajes = combi >= 16 && combi <= 28 ? "Hace un clima agradable" : "";
                Console.WriteLine(mensajes);
                mensajes = combi > 28 ? "Hace mucho calor" : "";
                Console.WriteLine(mensajes);
            }
            else
            {
                Console.WriteLine("Temperatura no valida");
            }
        } while (temperatura != "");
    }
}
