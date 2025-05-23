/*Una empresa de electrónica quiere llevar 
 * el inventario de sus productos. Desarrolla  
 * un algoritmo que permita al usuario ingresar 
 * la cantidad de productos a analizar, por 
 * cada producto se deberá solicitar el nombre 
 * y la cantidad de productos. Mostrar la cantidad 
 * de productos en total que tiene la tienda.*/

/*int totalProductos = 0, tipoProducto = 0;
Console.WriteLine("Ingrese cantidad de productos para analizar");
tipoProducto = int.Parse(Console.ReadLine());


for (int i = 0; i < tipoProducto; i++)
{
    Console.Clear();
    Console.WriteLine("Ingrese el nombre del producto");
    string nombre = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Ingrese la cantidade de {nombre}");
    totalProductos += int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine($"Total de productos: {totalProductos}");
*/


/*Una estación meteorológica toma las 
 * temperaturas diarias durante una 
 * semana. Desarrolla un algoritmo que 
 * permita al usuario ingresar las 
 * temperaturas de los 7 días (máxima y mínima) 
 * y mostrar el promedio de temperatura semanal.*/

double total = 0;
for (int i = 1; i <= 7; i++)
{
    Console.Clear();
    Console.WriteLine($"Ingrese la minima del día {i}");
    double minima = double.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese la maxima del dia {i}");
    double maxima = double.Parse(Console.ReadLine());
    Console.Clear();
    double promedio = (maxima + minima) / 2.0;
    Console.WriteLine($"Promedio del día {i}: {promedio.ToString("N2")}");
    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    total += minima;
    total += maxima;
}
Console.Clear();
double promedioTotal = total / 14.0;
Console.WriteLine($"Promedio de temperatura semanal: {promedioTotal.ToString("N2")}");