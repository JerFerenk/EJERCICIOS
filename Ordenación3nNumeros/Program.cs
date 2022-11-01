
internal class Progam
{

    static void Main(string[] args)
    {
        Console.WriteLine("Ordenamineto de 3 números");
        do
        {
            Console.Clear();
            Console.WriteLine("Ingresar Primer Número");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Segundo Número");
            int Num2 = int.Parse(Console.ReadLine());   
            Console.WriteLine("Ingresar Tercer Número");
            int Num3 = int.Parse(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine($"El número {Num1} es mayor");
                if (Num2 > Num3)
                {
                    Console.WriteLine($"El número {Num2} el de en medio");
                    Console.WriteLine($"El número {Num3} es el menor");
                }
                else
                {
                    Console.WriteLine($"El número {Num2} es el en medio");
                    Console.WriteLine($"El número {Num3} es el menor");
                }
            }

            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine($"El número {Num2} es mayor");
                if (Num1 > Num3)
                {
                    Console.WriteLine($"El número {Num1} el de en medio");
                    Console.WriteLine($"El número {Num3} es el menor");
                }
                else
                {
                    Console.WriteLine($"El número {Num1} es el en medio");
                    Console.WriteLine($"El número {Num3} es el menor");
                }
            }


            else if (Num3 > Num1 && Num3 > Num2)
            {
                Console.WriteLine($"El número {Num3} es mayor");
                if (Num2 > Num3)
                {
                    Console.WriteLine($"El número {Num2} el de en medio");
                    Console.WriteLine($"El número {Num3} es el meno");
                }
                else
                {
                    Console.WriteLine($"El número {Num2} es el menor");
                    Console.WriteLine($"El número {Num1} el de en medio");
                }
            }



            Console.ReadKey();
        }while(true);
    }
}


        