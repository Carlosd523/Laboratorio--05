using System;
class Program
{
    static void Main()
    {
        // Ejercicio número 1 - Determinar si un número es positivo, negativo o cero

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

        // Ejercicio número 2 - Determinar si un año es bisiesto

        //Entradas - Se le pide al usuario que agregue el año a determinar
        Console.WriteLine("Ingrese el año que quiera evaluar");
        string time = Console.ReadLine();
        int year = int.Parse(time!);

        //Proceso - Determinar si el año ingresado es bisiesto o no
        if (year % 400 == 0)
        {
            // Posible salida 1
            Console.WriteLine("El año sí es bisiesto");
        }else if (year % 100 == 0)
        {
            // Posible salida 2
            Console.WriteLine("El año no es bisiesto");
        }else if(year % 4 == 0)
        {
            // Posible salida 3
            Console.WriteLine("El año sí es bisiesto");
        }
        else
        {
            //Posible salida 4
            Console.WriteLine("El año no es bisiesto");
        }

        //Ejercicio número 3



        // Ejercicio número 4

    }
}