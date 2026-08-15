
/*
    Console.WriteLine("Que es usted?");

    int valor = 0;
    valor = int.Parse(Console.ReadLine());

    switch (valor)
    {
        case 0:
            Console.WriteLine("Soy un cero");
            break;
        case 1:
            Console.WriteLine("Soy un uno");
            break;
        case 2:
            Console.WriteLine("Soy un dos");
            break;
        default:
            Console.WriteLine("No soy nada");
            break;
    }




    if (valor == 0)
    {
        Console.WriteLine("Soy un cero");
    }
    else if (valor == 1)
    {
        Console.WriteLine("Soy un uno");
    }
    else if (valor == 2)
    {
        Console.WriteLine("Soy un dos");
    }
    else
    {
        Console.WriteLine("No soy nada");
    }
*/

while (true)
{



    Console.WriteLine("Ingrese el tipo de vehículo [MOTO, AUTO, CAMIONETA]");
    string vehiculo = Console.ReadLine().ToUpper();
    double precio = 0;
    switch (vehiculo)
    {
        case "MOTO":
            precio = 800;
            break;
        case "AUTO":
            precio = 1500;
            break;
        case "CAMIONETA":
            precio = 2200;
            break;
        default:
            Console.WriteLine("Tipo de vehículo no reconocido");
            break;
    }
    if (precio > 0)
    {
        Console.WriteLine("Ingrese la cantidad de horas de estacionamiento");
        int horas = int.Parse(Console.ReadLine());

        double total = precio * (double)horas;
        Console.WriteLine($"Importe a pagar: {total:C2}");
    }
}