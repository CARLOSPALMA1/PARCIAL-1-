using System;

class CuentaBancaria 
{
    private double saldo;

    public CuentaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public double ObtenerSaldo()
    {
        return saldo;
    }

    public void Depositar(double monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine($"Depósito de {monto:C} realizado correctamente.");
        }
        else
        {
            Console.WriteLine("El monto a depositar debe ser mayor que cero.");
        }
    }

    public void Retirar(double monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro de {monto:C} realizado correctamente.");
        }
        else
        {
            Console.WriteLine("Monto insuficiente o valor inválido para el retiro.");
        }
    }
}

class CajeroAutomatico
{
    static void Main()
    {
        // Crear una cuenta bancaria con un saldo inicial de 1000
        CuentaBancaria cuenta = new CuentaBancaria(1000);

        int opcion;

        do
        {
            MostrarMenu();
            opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Saldo disponible: {cuenta.ObtenerSaldo():C}");
                    break;

                case 2:
                    Console.Write("Ingrese el monto a depositar: ");
                    double montoDeposito = LeerDouble();
                    cuenta.Depositar(montoDeposito);
                    break;

                case 3:
                    Console.Write("Ingrese el monto a retirar: ");
                    double montoRetiro = LeerDouble();
                    cuenta.Retirar(montoRetiro);
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa. ¡Gracias por usar el cajero automático!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, elija una opción correcta.");
                    break;
            }

        } while (opcion != 4);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n===== Menú =====");
        Console.WriteLine("1. Verificar Saldo");
        Console.WriteLine("2. Depositar Dinero");
        Console.WriteLine("3. Retirar Dinero");
        Console.WriteLine("4. Salir");
        Console.Write("Ingrese el número de la opción deseada: ");
    }

    static int LeerOpcion()
    {
        int opcion;
        while (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.Write("Ingrese una opción válida: ");
        }
        return opcion;
    }

    static double LeerDouble()
    {
        double valor;
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Ingrese un valor válido: ");
        }
        return valor;
    }
}
