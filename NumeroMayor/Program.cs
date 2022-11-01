// See https://aka.ms/new-console-template for more information
Console.WriteLine("Número Mayor");

int a;
int b;
int c;
{ 
Console.WriteLine("Imprimir el valor a");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Imprimir el valor b");
b = int.Parse(Console.ReadLine());

Console.WriteLine("Imprimir el valor c");
c = int.Parse(Console.ReadLine());

    if (a < b)
    {
        if (b < c)
        {
            Console.WriteLine("{0} es mayor", c);
        }
        else
            Console.WriteLine("{0} es mayor", b);
    }
    else if (a > b)
    {
        if (a < c)
        {
            Console.WriteLine("{0} es mayor", c);
        }
        else
            Console.WriteLine("{0} es mayor", a);
    }
    Console.ReadKey();
}

