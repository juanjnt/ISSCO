bool respuesta = true;
double destino1 = 0, destino2 = 0, destino3 = 0;
string nombreDestino1, nombreDestino2, nombreDestino3;

Console.WriteLine("Ingrese el nombre del destino 1");
nombreDestino1 = Console.ReadLine();
Console.WriteLine($"Ingrese el valor del pasaje de {nombreDestino1}");
destino1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del destino 2");
nombreDestino2 = Console.ReadLine();
Console.WriteLine($"Ingrese el valor del pasaje de {nombreDestino2}");
destino2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del destino 3");
nombreDestino3 = Console.ReadLine();
Console.WriteLine($"Ingrese el valor del pasaje de {nombreDestino3}");
destino3 = double.Parse(Console.ReadLine());
Console.Clear();
while (respuesta)
{
    Console.Clear();
    Console.WriteLine("Desea ingresar un nuevo pasajero? 1- Si   //   2- No");
    string rsp = Console.ReadLine();
    if (rsp == "1")
    {
        Console.Clear();
        Console.WriteLine("Seleccione el destino");
        Console.WriteLine($"1- {nombreDestino1}");
        Console.WriteLine($"2- {nombreDestino2}");
        Console.WriteLine($"3- {nombreDestino3}");
        string resultado = Console.ReadLine();
        double precio = 0;
        double descuento = 0;
        string destinoFinal = string.Empty;
        switch (resultado)
        {
            case "1":
                precio = destino1;
                destinoFinal = nombreDestino1;
                break;
            case "2":
                precio = destino2;
                destinoFinal = nombreDestino2;
                break;
            case "3":
                precio = destino3;
                destinoFinal = nombreDestino3;
                break;
        }
        Console.Clear();
        Console.WriteLine("Seleccione el segmento");
        Console.WriteLine($"1- Jubilado");
        Console.WriteLine($"2- Estudiante");
        Console.WriteLine($"3- Trabajador");
        string segmento = Console.ReadLine();
        switch (segmento)
        {
            case "1":
                descuento = 0.60;
                break;
            case "2":
                descuento = 0.35;
                break;
            case "3":
                descuento = 0.25;
                break;
        }
        descuento = precio * descuento;
        double total = precio - descuento;
        Console.Clear();
        Console.WriteLine($"Precio del pasaje a {destinoFinal}: {precio:C2}");
        Console.WriteLine($"Descuento del pasaje a {destinoFinal}: {descuento:C2}");
        Console.WriteLine($"Total del pasaje a {destinoFinal}: {total:C2}");
        Console.WriteLine("[Enter para continuar]");
        Console.ReadLine();
    }
    else
    {
        respuesta = false;
    }
    
}