/*Un cargamento de productos tiene diferentes pesos:
Entrada: cantidad de productos.
Por cada producto, ingresar su peso en kg.
El peso total del envío y el costo de envío (por ejemplo, costo base + peso en kg * tarifa).
Si el peso total es mayor a 100 kg, aplicar un recargo adicional del 15% sobre el costo total.
Mostrar: peso total, costo sin recargo y costo final con recargo si aplica, es necesario 
ingresar una tarifa por kilo y un costo base, mostrar total recaudado por envíos y 
cantidad de kilos enviados.
 */
/*
costobase
tarifa * kilo
recargo?
 */


/*
Console.WriteLine("Ingrese la tarifa por kilo");
double tarifa = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de productos");
int productos = int.Parse(Console.ReadLine());
int kilosTotales = 0; double recaudacion = 0;


for (int i = 0; i < productos; i++)
{
    Console.WriteLine($"Ingrese los kilos del producto {i + 1}");
    int kilos = int.Parse(Console.ReadLine());
    kilosTotales += kilos;
    recaudacion += CostoEnvio(kilos);
}
Console.WriteLine($"Total de kilos enviados: {kilosTotales}");
Console.WriteLine($"Total recaudado: {recaudacion.ToString("N2")}");

double CostoEnvio(int kilos)
{
    Console.WriteLine("Ingrese el costo base");
    double costoBase = double.Parse(Console.ReadLine());
    double valor = ((double)kilos * tarifa) + costoBase;
    double recargo = Recargo(kilos, valor);
    Console.WriteLine($"Peso tota: {kilos}");
    Console.WriteLine($"Costo envío: ${valor.ToString("N2")}");
    Console.WriteLine($"Costo Recargo: ${recargo.ToString("N2")}");
    Console.WriteLine($"Costo total: ${(valor + recargo).ToString("N2")}");
    return valor + recargo;
}

double Recargo(int kilos, double costo)
{
    if (kilos > 100 && kilos <= 200)
    {
        return costo * 0.15;
    }
    else if (kilos > 200)
    {
        return costo * 0.4;
    }
    return 0;
}
*/
/*
double Recargo15(int kilos, double costo);

double CostoEnvio(double costoBase, int kilos); costo + recargo

double CostoEnvio(int kilos); costo + recargo
 
 */

/* Un médico necesita un sistema para la cobranza de sus honorarios.
Se ingresa el número de pacientes atendidos en un día.
Para cada paciente, ingresar la duración de la consulta en minutos.
Cada 15 minutos, el honorario aumenta en un porcentaje (por ejemplo, 10% cada 15 minutos extra).
Definir un valor de consulta, mostrar el total cobrado en el día.*/

const double consulta = 8000;
Console.WriteLine("Ingrese la cantidad de pacientes");
int pacientes = int.Parse(Console.ReadLine());
double total = 0;



for (int i = 1; i <= pacientes; i++)
{
    Console.WriteLine("Ingrese los minutos de la consulta");
    int minutos = int.Parse(Console.ReadLine());
    total += consulta + recargo(minutos);
}


double recargo (int minutos)
{
    if (minutos > 15)
    {
        double porcentaje = minutos / 15;
        porcentaje = porcentaje * 10;
        return  consulta * porcentaje / 100;
    }
    return 0;
}

