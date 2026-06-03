/*Un profesor desea analizar estadísticamente la edad de sus 
 * estudiantes en un curso. 
 * Necesita identificar quiénes son los más jóvenes y los 
 * mayores, además de calcular 
 * el promedio de edad para planificar actividades y dinámicas 
 * adaptadas.
Crea una clase Estudiante con propiedades Nombre y Edad. 
Ingresa datos de varios estudiantes (indeterminados). 
Al finalizar, el sistema debe indicar quién es el estudiante 
más joven, quién el mayor, 
cuál es la edad promedio del grupo, cuántos son menores de 
edad y cuántos son mayores de edad, 
para facilitar el análisis del perfil del grupo.*/

using Clase14;
/*
#region Estudiante
List<Estudiante> listaEstudiante = new List<Estudiante>();


while (true)
{
    Console.WriteLine("Ingresar un nuevo estudiante? 1-Si / 2-No");
    if (Console.ReadLine() == "1")
    {
        var estudiante = new Estudiante();
        Console.WriteLine("Ingrese el nombre del Estudiante");
        estudiante.Nombre = ValidacionString();
        Console.WriteLine("Ingrese la edad del Estudiante");
        estudiante.Edad = ValidacionEntero();
        listaEstudiante.Add(estudiante);
    }
    else
        break;
}
Resultados();
void Resultados()
{
    var max = new Estudiante();
    var min = new Estudiante();
    double promedio = 0;
    int mayores = 0, menores = 0;
    for (int i = 0; i < listaEstudiante.Count; i++)
    {
        var rw = listaEstudiante[i];
        if (i == 0)
        {
            max = rw;
            min = rw;
        }
        promedio += rw.Edad;
        if (rw.Edad >= 18)
            mayores++;
        else
            menores++;
        if (rw.Edad > max.Edad)
        {
            max = rw;
        }
        if (rw.Edad < min.Edad)
        {
            min = rw;
        }
    }
    promedio = promedio / (double)listaEstudiante.Count;
    Console.WriteLine($"Estudiante más grande: {max.Nombre}, ({max.Edad})");
    Console.WriteLine($"Estudiante más chico: {min.Nombre}, ({min.Edad})");
    Console.WriteLine($"Cantidad de mayores: {mayores}");
    Console.WriteLine($"Cantidad de menores: {menores}");
    Console.WriteLine($"Promedio de edad: {promedio:N2}");
}

#endregion
*/


/*Un comercio quiere analizar las ventas de sus productos 
 * para optimizar precios y promociones. Necesita saber 
 * cuáles productos tienen los mayores precios y qué porcentaje 
 * de su inventario supera cierto valor.
Crea una clase Producto con propiedades Nombre y Precio. 
Ingresa varios productos en inventario. 
Al terminar, calcula el total en inventario, calcula el promedio
de precios, y el porcentaje de productos que tienen un precio 
superior a $10000.*/

/*var listaProducto =  new List<Producto>();

while (true)
{
    Console.WriteLine("Ingresar un nuevo producto? 1-Si / 2-No");
    if (Console.ReadLine() == "1")
    {
        var producto = new Producto();
        Console.WriteLine("Ingrese el nombre del Producto");
        producto.Nombre = ValidacionString();
        Console.WriteLine("Ingrese el precio del Producto");
        producto.Precio = ValidacionEntero();
        listaProducto.Add(producto);
    }
    else
        break;
}
Resultado();
void Resultado()
{
    var max = new Producto();
    double promedio = 0, total = 0, porcentaje = 0;
    for (int i = 0; i < listaProducto.Count; i++)
    {
        var rw = listaProducto[i];
        if (i == 0)
            max = rw;
        total += rw.Precio;
        if (rw.Precio > 10000)
            porcentaje++;
        if (rw.Precio > max.Precio)
            max = rw;
    }
    promedio = total / (double)listaProducto.Count;
    porcentaje = (porcentaje / (double)listaProducto.Count) * 100.0;

    Console.WriteLine($"Producto más caro: {max.Nombre}, ({max.Precio:C2})");
    Console.WriteLine($"Promedio de precios: {promedio:C2}");
    Console.WriteLine($"Porcentaje > $10000: {porcentaje:N2}%");
    Console.WriteLine($"Total de productos: {total:C2}");
}
*/























#region Validaciones
double ValidacionDouble()
{
    double valor = 0;
    while (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor incorrecto");
    }
    return valor;
}
string ValidacionString()
{
    string nombre = string.Empty;
    while (true)
    {
        nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre))
            Console.WriteLine("Error en el valor ingresado");
        else
            break;
    }
    return nombre;
}
int ValidacionEntero()
{
    int valor = 0;
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor incorrecto");
    }
    return valor;
}
#endregion