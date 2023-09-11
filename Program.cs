

using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1. Calcular promedio de 3 notas.");
            Console.WriteLine("2. Verificar si un número es par o impar.");
            Console.WriteLine("3. Listar números descendentes desde 100 hasta 90.");
            Console.WriteLine("4. Imprimir apellidos en mayúscula y nombres en minúscula.");
            Console.WriteLine("5. Calcular la edad a partir de la fecha de nacimiento.");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese su elección (1-6): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CalcularPromedio();
                        break;
                    case 2:
                        VerificarParImpar();
                        break;
                    case 3:
                        ListarDescendente();
                        break;
                    case 4:
                        ImprimirNombres();
                        break;
                    case 5:
                        CalcularEdad();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }

            Console.WriteLine();
        } while (opcion != 6);
    }

    static void CalcularPromedio()
    {
        Console.WriteLine("Ingrese las tres notas separadas por espacios:");
        string[] notas = Console.ReadLine().Split();
        double nota1, nota2, nota3;

        if (notas.Length == 3 && double.TryParse(notas[0], out nota1) && double.TryParse(notas[1], out nota2) && double.TryParse(notas[2], out nota3))
        {
            double promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAprobado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nReprobado");
            }

            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Asegúrese de ingresar tres notas válidas.");
        }
    }

    static void VerificarParImpar()
    {
        Console.Write("Ingrese un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("\nEl número es par.");
            }
            else
            {
                Console.WriteLine("\nEl número es impar.");
            }
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Ingrese un número entero.");
        }
    }

    static void ListarDescendente()
    {
        Console.WriteLine("\nNúmeros descendentes desde 100 hasta 90:");
        for (int i = 100; i >= 90; i--)
        {
            Console.WriteLine(i);
        }
    }

    static void ImprimirNombres()
    {
        Console.Write("Ingrese un nombre completo 2 Nombres y 2 Apellidos: ");
        string nombreCompleto = Console.ReadLine();
        string[] partes = nombreCompleto.Split(' ');

        if (partes.Length == 4)
        {
           
            string nombres = partes[0] + " " + partes[1];
             string apellidos = partes[2] + " " + partes[3];

            Console.WriteLine("\nApellidos en mayúscula: " + apellidos.ToUpper());
            Console.WriteLine("Nombres en minúscula: " + nombres.ToLower());
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Ingrese un nombre completo con 4 partes.");
        }
    }

    static void CalcularEdad()
    {
        Console.Write("Ingrese su fecha de nacimiento (YYYY-MM-DD): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }

            Console.WriteLine("\nTiene " + edad + " años.");
        }
        else
        {
            Console.WriteLine("\nEntrada no válida. Ingrese una fecha válida en formato YYYY-MM-DD.");
        }
    }
}