using System;

class Program
{
    static void Main()
    {
        int numero;
        int suma = 0;
        int cantidadNumeros = 0;

        Console.WriteLine("Ingrese números (ingrese 0 para terminar):");

        do
        {
            Console.Write("Ingrese un número: ");
            numero = LeerEntero();

            if (numero != 0)
            {
                suma += numero;
                cantidadNumeros++;
            }

        } while (numero != 0);

        if (cantidadNumeros > 0)
        {
            double promedio = (double)suma / cantidadNumeros;

            Console.WriteLine($"Suma de los números: {suma}");
            Console.WriteLine($"Promedio de los números: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }
    }

    static int LeerEntero()
    {
        int valor;
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Ingrese un número válido: ");
        }
        return valor;
    }
}