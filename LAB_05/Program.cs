using System;
class Program
{
    static void Main()
    {
        // Ejercicio número 1

        // Entradas - Se le pide al usuario que ingrese un número entero.
        Console.WriteLine("Ingrese un número entero");
        string numero = Console.ReadLine();
        int num = int.Parse(numero!);

        //Proceso - El número que ingresó el usuario será evaluado para determinar si es positivo, negativo o es cero.
        if (num > 0)
        {
            // Posible salida número 1
            Console.WriteLine("El número ingresado es positivo");
        }else if(num < 0)
        {
            // Posible salida número 2
            Console.WriteLine("El número ingresado es negativo");
        }
        else
        {
            // Posible salida número 3
            Console.WriteLine("El número ingresado es cero");
        }

    }

        // Ejercicio número 2



        //Ejercicio número 3



        // Ejercicio número 4
}