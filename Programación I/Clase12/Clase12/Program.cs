/*2- La administración de un negocio 
 * necesita registrar las ventas diarias. 
 * Ingresa los montos de ventas y finaliza 
 * cuando ingrese -1.  
Mostrar la suma total de las ventas realizadas.
Indicar cuántas ventas superaron los $50.*/

/*
List<double> lista = new List<double>();

while (true)
{
    Console.WriteLine("Ingrese el importe de la venta");
    double venta = 0;
    if (!double.TryParse(Console.ReadLine(), out venta))
    {
        Console.WriteLine("Error en el valor ingresado");
    }
    else
    {
        if (venta >= 0)
            lista.Add(venta);
        else
            break;
    }
    
}
Resultados();

void Resultados()
{
    double total = 0;
    int cantidad = 0;
    foreach (var item in lista)
    {
        total += item;
        if (item > 5000)
        {
            cantidad++;
        }
    }
    Console.WriteLine($"Ventas realizadas {total:C2}");
    Console.WriteLine($"Cantidad de ventas mayores a $5000: {cantidad}");
}
*/

/*3- Es necesario recopilar las notas 
 * de un grupo de estudiantes. Ingresa 
 * las notas hasta que se ingrese un valor negativo.  
Calcular el promedio general.
Contar cuántos tienen notas mayores a 7.
Mostrar todas las notas menores a 4.*/
/*
List<int> listaNotas = new List<int>();

while (true)
{
    Console.WriteLine("Ingrese la nota");
    int nota = 0;
    if (!int.TryParse(Console.ReadLine(), out nota))
    {
        Console.WriteLine("Error en el valor ingresado");
    }
    else
    {
        if (nota >= 0)
            listaNotas.Add(nota);
        else
            break;
    }
}
Resultados();
void Resultados()
{
    double promedio = 0;
    int suma = 0;
    int mas7 = 0;
    int menos4 = 0;
    foreach (var item in listaNotas)
    {
        suma += item;
        if (item > 7)
            mas7++;
        if (item < 4)
            menos4++;
    }
    promedio = (double)suma / (double)listaNotas.Count;
    Console.WriteLine($"Promedio general: {promedio:N2}");
    Console.WriteLine($"Notas mayores a 7: {mas7}");
    Console.WriteLine($"Notas menores a 4: {menos4}");
}*/

/*4- Se necesita gestionar el inventario de 
 * productos en un comercio. Ingresa el nombre 
 * y la cantidad de cada producto, y finaliza 
 * cuando ingrese un valor en blanco en nombre 
 * o cantidad 0.  
Mostrar todos los productos con cantidad menor 
o igual a 5.
Contar cuántos productos hay en total.*/
/*
List<(string producto, int cantidad)> lista = 
    new List<(string producto, int cantidad)>();

while (true)
{
    Console.WriteLine("Ingrese el nombre del producto");
    string nombre = Console.ReadLine();
    if (string.IsNullOrEmpty(nombre))
        break;
    Console.WriteLine("Ingrese la cantidad de productos");
    int cantidad = 0;
    if (!int.TryParse(Console.ReadLine(), out cantidad))
        Console.WriteLine("Error en el valor ingresado");
    else
    {
        if (cantidad > 0)
            lista.Add((nombre, cantidad));
        else
            break;
    }
}
Resultado();
void Resultado()
{
    int menor5 = 0;
    int total = 0;
    foreach (var item in lista)
    {
        total += item.cantidad;
        if (item.cantidad <= 5)
        {
            Console.WriteLine($"Menor a 5 -> {item.producto}: {item.cantidad}");
            menor5++;
        }
    }
    Console.WriteLine($"Cantidad de productos menor a 5: {menor5}");
    Console.WriteLine($"Cantidad de productos totales: {total}");
}*/