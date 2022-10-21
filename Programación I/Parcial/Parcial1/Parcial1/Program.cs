/*
Calcular precio de venta
-Obtener el precio de costo por kilo de tomate x
-Calcular 45% de ganancia, precio de venta
-Calcular 15% de ganancia, precio de venta

Obtener ganancia
-Obtener el precio del tomate
-Obtener el peso del cajón de tomates
-Obtener el 90% del peso del cajón
-Obtener el 10% del peso del cajón
-Obtener el 45% de ganancia del 90% del cajón
-Obtener el 15% de ganancia del 10% del cajón 
-Sumar las ganancias

 



 */
/*
Console.WriteLine("Ingrese el precio de costo del kilo de tomates");
decimal precio = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de ganancia, tomate bueno");
Console.WriteLine("Tomate bueno: $" + CalcularPrecioVenta(45));
Console.WriteLine("Tomate malo-: $" + CalcularPrecioVenta(15));
Console.WriteLine("Enter para continual");
Console.ReadLine();
GananciaCajon();


decimal CalcularPrecioVenta(decimal ganancia)
{
    return precio + ((precio * ganancia) / 100);
}

decimal CalculoGanancia(decimal ganancia, decimal precioCajon)
{
    return (precioCajon * ganancia) / 100;
}


void GananciaCajon()
{
    Console.Clear();
    Console.WriteLine("Ingrese el peso del cajon de tomates");
    decimal peso = Convert.ToDecimal(Console.ReadLine());
    decimal totalBueno = (peso * (decimal)0.9) * precio;
    decimal totalMalo = (peso * (decimal)0.1) * precio;

    decimal ganancia = CalculoGanancia(45, totalBueno) + CalculoGanancia(15, totalMalo);
    Console.WriteLine("La ganancia por el cajon de tomates es de $" + ganancia);
    Console.WriteLine("Enter para continual");
    Console.ReadLine();
    GananciaCajon();
}*/

/*Console.WriteLine("Ingrese el precio de costo del kilo de tomates");
decimal precio = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de ganancia, tomate bueno");
decimal precioBueno = precio * (decimal)1.45;
Console.WriteLine("Tomate bueno: $" + precioBueno);
decimal precioMalo = precio * (decimal)1.15;
Console.WriteLine("Tomate malo-: $" + precioMalo);
Console.WriteLine("Enter para continual");
Console.ReadLine();
GananciaCajon();


void GananciaCajon()
{
    Console.Clear();
    Console.WriteLine("Ingrese el peso del cajon de tomates");
    decimal peso = Convert.ToDecimal(Console.ReadLine());
    decimal totalBueno = (peso * (decimal)0.9) * precio;
    decimal totalMalo = (peso * (decimal)0.1) * precio;
    decimal gananciaBuena = totalBueno * (decimal)0.45;
    decimal gananciaMalo = totalMalo * (decimal)0.15;


    decimal ganancia = gananciaBuena + gananciaMalo;
    Console.WriteLine("La ganancia por el cajon de tomates es de $" + ganancia);
    Console.WriteLine("Enter para continual");
    Console.ReadLine();
    GananciaCajon();
}*/


/*
Calcular cantidad de combustible por kilómetro
-Obtener la cantidad de kilómetros del viaje
-Obtener el consumo total de combustible
-Calcular cuándo combustible gasto por 1km
-combustible / kilometros

Calcular el costo del kilometro
-Obtener el precio del combustible
-Calcular el costo por kilometro

 * */

/*Console.WriteLine("Ingrese la cantidad de kilometros total del viaje");
decimal kilometosTotal = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad total de combustible consumido");
decimal consumoTotal = Convert.ToDecimal(Console.ReadLine());

decimal combustibleKm = consumoTotal / kilometosTotal;
Console.WriteLine("Cantidad de combustible por kilometro: " + combustibleKm);


Console.WriteLine("Ingrese el precio del combustible");*/

/*string a = "kadfn las aksdlmfñlaksmdflasldf lasdf mklñasm kldflmkaskdfl kasdlkmfñlkm asdkfklasdflkasdlf asld";
int b = a.Length;
Console.WriteLine(b);*/

/*decimal precio = Convert.ToDecimal(Console.ReadLine());
decimal costoKm = combustibleKm * precio;
Console.WriteLine("Costo por kilometro recorrido: $" + costoKm);*/



int carga = 0;
Console.WriteLine("Ingrese la cantidad de canciones a cargar");
int cantidad = Convert.ToInt32(Console.ReadLine());

string[] titulos = new string[cantidad];
int[] caracteres = new int[cantidad];
guardar();



void guardar()
{

    Console.WriteLine("Ingrese el titulo de la canción");
    string titulo = Console.ReadLine();
    Console.WriteLine("Ingrese la canción");
    string cancion = Console.ReadLine();
    int count = cancion.Length;
    titulos[carga] = titulo;
    caracteres[carga] = count;
    ++carga;

    if (cantidad != carga)
    {
        Console.Clear();
        guardar();
    }
    else
    {
        Console.Clear();
        for (int i = 0; i < titulos.Length; i++)
        {
            Console.WriteLine("Canción Nº" + (i + 1));
            Console.WriteLine("Titulo: " + titulos[i]);
            Console.WriteLine("Cantidad de caracteres: " + caracteres[i]);
        }
    }
}



  


