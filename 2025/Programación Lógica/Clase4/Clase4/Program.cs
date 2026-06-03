/*bool respuesta = true;
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
    
}*/


/*Un árbol en condiciones normales llega a su altura máxima a los 15 años, 
 * pero en los últimos 5 años solo crece un 15%, y en los primeros 5 años 
 * el 50%, si el suelo es árido tiene una demora del 30% en sus procesos, 
 * y si el suelo es muy fértil lo hace un 20% más rápido. Seleccionando un 
 * tipo de suelo y dada una altura máxima del árbol imprima un detalle del 
 * crecimiento por año.*/
/*
while (true)
{
    double alturaMaxima = 0, etapa3 = 0, etapa2 = 0, etapa1 = 0, crecimiento = 0, descuento = 0;
    Console.WriteLine("Ingrese la altura maxima del arbol");
    alturaMaxima = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el tipo de suelo:");
    Console.WriteLine("1- Normal");
    Console.WriteLine("2- Arido");
    Console.WriteLine("3- Fertil");
    etapa3 = ((alturaMaxima * 15) / 100) / 5;
    etapa1 = ((alturaMaxima / 2)) / 5;
    etapa2 = ((alturaMaxima * 35) / 100) / 5;
    string respuesta = Console.ReadLine();
    switch (respuesta)
    {
        case "1":

            break;
        case "2":
            etapa3 = etapa3 * 0.7;
            etapa2 = etapa2 * 0.7;
            etapa1 = etapa1 * 0.7;
            break;
        case "3":
            etapa3 = etapa3 * 1.2;
            etapa2 = etapa2 * 1.2;
            etapa1 = etapa1 * 1.2;
            break;
    }

    for (int i = 1; i <= 15; i++)
    {
        if (i <= 5)
        {
            crecimiento += etapa1;
            Console.WriteLine($"Altura año {i}: {crecimiento:N2} metros");
        }
        else if (i > 5 && i <= 10)
        {
            crecimiento += etapa2;
            Console.WriteLine($"Altura año {i}: {crecimiento:N2} metros");
        }
        else
        {
            crecimiento += etapa3;
            Console.WriteLine($"Altura año {i}: {crecimiento:N2} metros");
        }
    }



}
*/

/*Para ver películas en 4K se necesita como mínimo una conexión de 20mb, 
 * para poder descargar a 2.5mbps, ya que 8 bits equivalen a 1 byte, los 
 * servicios de internet esta expresados en bits y las velocidades de descarga 
 * en bytes, dado un servicio de internet de XXmb necesito realizar un programa 
 * que me indique que tiempo voy a tardar para descargar XX GB.*/

