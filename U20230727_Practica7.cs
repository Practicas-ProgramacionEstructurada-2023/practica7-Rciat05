using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("\n************************************************************");
                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Opción 1: Suma de Números Pares e Impares en un Rango");
                Console.WriteLine("2. Opción 2: Adivina el número secreto (entre 1 y 10)");
                Console.WriteLine("3. Opción 3: Tablas de multiplicar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("************************************************************");

                Console.Write("Seleccione una opción: ");
                string? opcion = Convert.ToString(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Numparimpar();
                        break;

                    case "2":
                        Numsecreto();
                        break;

                    case "3":
                        Console.WriteLine("\n**********Tablas de multiplicar**********");
                        Console.Write("\nIngresa un número para ver su tabla de multiplicar: ");
                        int numero = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nTabla de multiplicar del " + numero + ":");

                        for (int i = 1; i <= 10; i++)
                        {
                            int resultado = numero * i;
                            Console.WriteLine(numero + " x " + i + " = " + resultado);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Saliendo del programa......");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine();
            } while (!salir);

            Console.ReadKey();
        }

        static void Numparimpar()
        {
            Console.WriteLine("\n**********Suma de Números Pares e Impares en un Rango**********\n");
            Console.Write("Ingrese un número entero positivo: ");

            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                int sumaPares = 0;
                int sumaImpares = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumaPares += i; 
                    }
                    else
                    {
                        sumaImpares += i; 
                    }
                }

                Console.WriteLine("\nLa suma de los números pares en el rango es: " + sumaPares);
                Console.WriteLine("La suma de los números impares en el rango es: " + sumaImpares);
            }

            else
            {
                Console.WriteLine("Debe ingresar un número entero positivo válido.");
            }
        }

        static void Numsecreto()
        {
            Random random = new();
            int numeroSecreto = random.Next(1, 11);
            int intentos = 0;
            int intentoUsuario;

            Console.WriteLine("\n**********Adivina el número secreto (entre 1 y 10)**********");

            while (true)
            {
                intentos++;

                Console.Write("\nIngresa tu intento: ");
                if (int.TryParse(Console.ReadLine(), out intentoUsuario) && intentoUsuario > 0 && intentoUsuario < 11)
                {
                    if (intentoUsuario == numeroSecreto)
                    {
                        Console.WriteLine("¡Felicitaciones! Adivinaste el número secreto el cual es " + numeroSecreto + " y fue adivinado en " + intentos + " intentos.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Intenta de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un número válido.");
                }
            }
        }
    }
}
