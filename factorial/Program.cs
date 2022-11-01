using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            int sist;
            int jerfer;
            int moon;
            Console.Write("Ingrese un numero: ");
            moon = int.Parse(Console.ReadLine());
            if (moon == 0)
            {
                Console.WriteLine("El factorial de 0 es: 1");
            }
            else
            {
                sist = moon;
                for (jerfer = moon; jerfer > 1; jerfer--)
                {
                    sist = sist * (jerfer - 1);
                }
                Console.WriteLine($"El factorial de {moon} es {sist}");
            }
            Console.ReadKey();
        }
    }