/*Un centro cultural organiza talleres de diferentes temáticas. 
 * Cobran $5000 por taller y ofrecen un descuento del 10% si se 
 * inscriben en más de 3 talleres. Solicita al usuario la cantidad 
 * de personas a inscribir y por cada 
personas  los talleres en los cuales quiere participar, informar el 
costo de la inscripción para esa persona, mostrar el total recaudado, 
total de descuento y que cantidad total de inscripciones hay en los talleres.*/

/*int personas = 0, talleres = 0, totalTalleres = 0;
double totalDescuento = 0, totalPago = 0;
Console.WriteLine("Ingrese la cantidad de personas");
personas = int.Parse(Console.ReadLine());

for (int i = 1; i <= personas; i++)
{
    Console.WriteLine("Cantidad de talleres a participar");
    talleres = int.Parse(Console.ReadLine());
    totalTalleres += talleres;
    double pago = (double)talleres * 5000.0;
    if (talleres >= 3)
    {
        double descuento = pago * 0.10;
        totalDescuento += descuento;
        pago = pago - descuento;
    }
    totalPago += pago;
    Console.WriteLine($"Total a pagar {pago:N2}");
}
Console.WriteLine("--------------------");
Console.WriteLine($"Total de descuento: {totalDescuento:N2}");
Console.WriteLine($"Total recaudado: {totalPago:N2}");
Console.WriteLine($"Cantidad de cursos inscriptos: {totalTalleres}");*/


int valor = int.Parse(Console.ReadLine());
Console.WriteLine("-------");
for (int i = valor; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------");
while (valor >= 0)
{
    Console.WriteLine(valor);
    valor--;
}