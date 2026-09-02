
/*Console.WriteLine("Ingrese el importe de comida");
double comidaRead = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de comida");
int cantidadComidaRead =int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el importe de bebida");
double bebidaRead = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de bebida");
int cantidadBebidaRead = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el importe de entrada");
double entradaRead = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de entrada");
int cantidadEntradaRead = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de personas");
int personasRead = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de propina");
double propinaRead = double.Parse(Console.ReadLine());


double totalAPagar = CalcularTotal(comidaRead, cantidadComidaRead, bebidaRead, cantidadBebidaRead, entradaRead, cantidadEntradaRead );

CalculoPorPersona(personasRead, totalAPagar, Propina(totalAPagar, propinaRead));


double CalcularTotal(double comida, int cantidadComida, double bebida, int cantidadBebida, double entrada, int cantidadEntrada)
{ 
    double total = 0;
    total += comida * (double)cantidadComida;
    total += bebida * (double)cantidadBebida;
    total += entrada * (double)cantidadEntrada;
    return total;
}

void CalculoPorPersona(int personas, double total, double propina)
{ 
    double personaTotal = total / (double)personas;
    double personaPropina = propina / (double)personas;
    Console.WriteLine($"Total por persona de comida: {personaTotal:C2}");
    Console.WriteLine($"Total por persona de propina: {personaPropina:C2}");
    Console.WriteLine($"Total a pagar por persona: {(personaTotal + personaPropina):C2}");

}

double Propina(double total, double porcentaje)
{
    return total * porcentaje / 100;
}*/

/*Una estación de peaje necesita calcular el cobro de vehículos mediante una función.

Crear la función CalcularMontoPeaje que reciba el tipoVehiculo (1: Moto, 2: Auto, 3: Camión) 
y la cantidadEjes (numérico).

Tarifas base: Moto = $800, Auto = $1500, Camión = $3000.

Si el vehículo es Camión y tiene más de 2 ejes, cobrar un recargo de $500 por cada eje extra.

La función debe retornar el tipo double con el precio final. 
Probar invocándola desde el programa principal con 3 vehículos distintos e imprimir sus totales.*/
Console.WriteLine($"Prueba1: {CalcularMontoPeaje(1, 0)}");
Console.WriteLine($"Prueba2: {CalcularMontoPeaje(2, 0)}");
Console.WriteLine($"Prueba3: {CalcularMontoPeaje(3, 4)}");

while (true)
{
    Console.WriteLine("Ingrese el tipo de vehículo: 1- moto, 2- auto, 3- camión");
    int vehiculo = int.Parse(Console.ReadLine());
    int ejes = 0;
    if (vehiculo == 3)
    {
        Console.WriteLine("Ingrese la cantidad de ejes");
        ejes = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Importe a pagar por peaje: {CalcularMontoPeaje(vehiculo, ejes):C2}");
}







double CalcularMontoPeaje(int tipoVehiculo, int cantidadEjes)
{
    double tarifa = TarifaBase(tipoVehiculo);
    if (tipoVehiculo == 3 && cantidadEjes > 2)
    {
        tarifa += ((cantidadEjes - 2) * 500);
    }
    return tarifa;

}

double TarifaBase(int tipoVehiculo)
{
    double tarifa = 0;
    switch (tipoVehiculo)
    {
        case 1:
            tarifa = 800;
            break;
        case 2:
            tarifa = 1500;
            break;
        case 3:
            tarifa = 3000;
            break;
    }
    return tarifa;
}