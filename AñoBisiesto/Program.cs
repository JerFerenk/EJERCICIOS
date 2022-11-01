
    class MainClass
    {
     
        static void iniciar()
        {
            int num_año;
            Console.Clear();
            Console.Write("Ingresa el año: ");
            num_año = int.Parse(Console.ReadLine());

            if (num_año % 4 == 0)
            {
                if (num_año % 100 == 0)
                {
                    if (num_año % 400 == 0)
                    {
                        Console.WriteLine("Si es Año Bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("No es Año Bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Si es un Año Bisiesto");
                }
            }
            else
            {
                Console.WriteLine("No es un Año Bisiesto");
            }

        }
    }
