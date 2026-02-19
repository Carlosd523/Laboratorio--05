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

        // Proceso - El número que ingresó el usuario será evaluado para determinar si es positivo, negativo o es cero.
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

        // Entradas - Se le pide al usuario que agregue el año a determinar
        Console.WriteLine("Ingrese el año que quiera evaluar");
        string time = Console.ReadLine();
        int year = int.Parse(time!);

        // Proceso - Determinar si el año ingresado es bisiesto o no
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
            // Posible salida 4
            Console.WriteLine("El año no es bisiesto");
        }

        // Ejercicio número 3

        // Entradas - Se le pide al usuario que agregue su salario. También se determina multa como booleano.
        Console.WriteLine("Ingrese su salario mensual");
        string salario = Console.ReadLine();
        double salary = double.Parse(salario!);
        Console.WriteLine("¿Usted tiene multas por pagar? (true/false)");
        string multa = Console.ReadLine();
        bool valorBooleano = bool.Parse(multa!);

        // Proceso - Se determina el boleto de ornato a pagar
        // Bloque if 1 - Determinar el arbitrio a pagar
        double arbitrio = 0;
        if(salary < 500.01)
        {
            arbitrio = 00.00;
        }
        else if (salary<= 1000.00)
        {
            arbitrio = 10.00;
        }
        else if (salary <= 3000.00)
        {
            arbitrio = 15.00;
        }
        else if (salary <= 6000.00)
        {
            arbitrio = 50.00;
        }
        else if (salary <= 9000.00)
        {
            arbitrio = 75.00;
        }
        else if (salary <= 12000.00)
        {
            arbitrio = 100.00;
        }
        else
        {
            arbitrio = 150.00;
        }

        // Bloque if 2 - Determinar el monto a pagar teniendo en consideración la multa
        double monto = 0;
        if(arbitrio > 0)
        {
            if (valorBooleano)
            {
                monto = arbitrio * 2;
                // Posible salida 1
                Console.WriteLine("Deberá de pagar Q" + monto + " de boleta de ornato");
            }
            else
            {
                monto = arbitrio;
                // Posible salida 2
                Console.WriteLine("Deberá de pagar Q" + monto + " de boleta de ornato");
            }
        }
        else
        {
            // Posible salida 3
            Console.WriteLine("No tiene que pagar boleta de ornato");
        }

        // Ejercicio número 4

        // Entradas - El usuario ingresa las horas estacionadas, se calcula el monto a pagar y el monto ingresado como números enteros.
        Console.WriteLine("Ingrese la cantidad de horas que estuvo parqueado");
        string horas = Console.ReadLine();
        int hours = int.Parse(horas!);
        int payment = hours * 10;
        Console.WriteLine("Ingrese el monto que va a ingresar para pagar el parqueo");
        string mont = Console.ReadLine();
        int amount = int.Parse(mont!);

        // Proceso - Se indica si la cantidad ingresada no es suficiente, si es la justa o si se le tiene que dar cambio al usuario.
        if(payment > amount)
        {
            // Posible salida 1
            Console.WriteLine("¡Error! Los fondos ingresados son insuficientes");
        }else if(payment == amount)
        {
            // Posible salida 2
            Console.WriteLine("No se requiere cambio, ¡Feliz día!");
        }
        else
        {
            int cambio = amount - payment;
            int resto = 0;

            // Proceso para determinar la cantidad de billetes devueltos en cambio
            int billete100 = cambio / 100;
            resto = cambio % 100;
            int billete50 = resto / 50;
            resto = resto % 50;
            int billete20 = resto / 20;
            resto = resto % 20;
            int billete10 = resto / 10;
            resto = resto % 10;
            int billete5 = resto / 5;
            resto = resto % 5;
            int billete1 = resto / 1;

            // Posible salida 3
            Console.WriteLine("Se le dará Q" + cambio + " de cambio");
            Console.WriteLine("Billetes de Q100 devueltos: " + billete100);
            Console.WriteLine("Billetes de Q50 devueltos: " + billete50);
            Console.WriteLine("Billetes de Q20 devueltos: " + billete20);
            Console.WriteLine("Billetes de Q10 devueltos: " + billete10);
            Console.WriteLine("Billetes de Q5 devueltos: " + billete5);
            Console.WriteLine("Billetes de Q1 devueltos: " + billete1);
        }
    }
}