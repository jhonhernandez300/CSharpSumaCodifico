using System;

// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Ingrese un número entero positivo: ");
    string input = Console.ReadLine();
    int num;

    try
    {
        num = int.Parse(input);
        if (num <= 0)
        {
            Console.WriteLine("El número debe ser mayor que cero. Intente nuevamente.");
            continue;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("El valor ingresado no es un número entero válido. Intente nuevamente.");
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine("El número ingresado es demasiado grande. Intente nuevamente.");
        continue;
    }

    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }

    Console.WriteLine($"La suma de los números enteros desde 1 hasta {num} es: {sum}\n");
}
