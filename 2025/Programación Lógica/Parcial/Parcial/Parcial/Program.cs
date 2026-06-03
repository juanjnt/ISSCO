//ejercicio 1
/*double humedad = 0, hora = 0;
Console.WriteLine("Ingrese el porcentaje de humedad");
humedad = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la hora de día");
hora = double.Parse(Console.ReadLine());

if (humedad < 30)
{
    Console.WriteLine("Riego activado");
}
else if (humedad >= 30 && humedad <= 70)
{
	if (hora >= 8 && hora <= 20)
	{
        Console.WriteLine("Riego activado");
    }
	else
	{
        Console.WriteLine("Riego NO activado");
    }  
}
else
{
    Console.WriteLine("Riego NO activado");
}*/

//ejercicio 2
/*
double bateriaLlena = 8000 * 10, bateria = bateriaLlena;

while (bateria > 0)
{

    Console.WriteLine("Ingrese la distancia en metros de proximo viaje");
    double viaje = double.Parse(Console.ReadLine());
    if (viaje <= bateria)
    {
        double porcentaje = (bateria * 100) / bateriaLlena;
        Console.WriteLine($"Porcentaje de bateria {porcentaje}%");
        bateria -= viaje;
    }
    else
    {
        Console.WriteLine("Bateria no alcanza para el viaje");
        double porcentaje = (bateria * 100) / bateriaLlena;
        Console.WriteLine($"Porcentaje de bateria {porcentaje}%");
        bateria = 0;
    }
}*/

//ejercicio 3
/*
double calidad = 0, limpieza = 0;
Console.WriteLine("Ingrese la cantidad de personas a encuestar");
int personas = int.Parse(Console.ReadLine());
for (int i = 1; i <= personas; i++)
{
    Console.WriteLine($"Encuenta Nº {i}");
    Console.WriteLine("Ingrese la valoración de Calidad / Comodidad");
    calidad += double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la valoracion de Limpieza");
    limpieza += double.Parse(Console.ReadLine());
}
limpieza = limpieza / (double)personas;
calidad = calidad / (double)personas;
Console.WriteLine($"Valoracion de Calidad / Comodidad {calidad} Puntos");
Console.WriteLine($"Valoracion de Limpieza {limpieza} Puntos");*/

//Ejercicio 4
/*double basico = 0, completo = 0;

Console.WriteLine("Ingrese la cantidad de vehículos con lavado básico");
basico = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de vehículos con lavado completo");
completo = int.Parse(Console.ReadLine());
double cera = completo * 0.1;
basico = basico * 0.2;
completo = completo * 0.3;
double jabon = basico + completo;

Console.WriteLine($"Consumo de Jabón: {jabon:N2}");
Console.WriteLine($"Consumo de Cera: {cera:N2}");*/


//Ejercicio 5
Console.WriteLine("Ingrese el precio del producto");
double precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de productos comprados");
double producto = double.Parse(Console.ReadLine());

double fueraPromo = producto % 5;
double precioPromo = precio * 4;

double totalPromo = (producto - fueraPromo) / 5;

double total = precio * producto;
double descuentoPromo = total - (((precioPromo * totalPromo)) + (fueraPromo * precio));
double porcentaje = 0;
if (total > 50000 || producto > 20)
{
    porcentaje = (total - descuentoPromo) * 0.12;
}

double totalPago = total - descuentoPromo - porcentaje;
Console.WriteLine($"Total a pagar sin descuentos: ${total:N2}");
Console.WriteLine($"Descuento 4x5: ${descuentoPromo:N2}");
Console.WriteLine($"Descuento Extra: ${porcentaje:N2}");
Console.WriteLine($"Total a pagar: ${totalPago:N2}");


