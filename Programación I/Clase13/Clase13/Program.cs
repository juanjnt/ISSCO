/*Crea una clase Producto con atributos como nombre y precio.
Permite agregar varias instancias en una lista.
Calcula el total del inventario y busca el producto más caro y el más barato.
Muestra toda la lista con sus precios y el total.*/

using Clase13;
using System.Data;

/*List<Producto> listaProducto = new List<Producto>();


while (true)
{
    Console.WriteLine("Ingresar un nuevo producto? 1-Si / 2-No");
	if (Console.ReadLine() == "1")
	{
		Console.WriteLine("Ingrese el nombre");
		string nombre = ValidacionString();
		Console.WriteLine("Ingrese el precio");
		double precio = ValidacionDouble();
		listaProducto.Add(new Producto() { Nombre = nombre, Precio = precio });
    }
	else
		break;
}
Resultados();

void Resultados()
{
	Console.WriteLine("Lista de Precios:");
	double  total = 0;
	var max = new Producto();
	var min = new Producto();
	for (int i = 0; i < listaProducto.Count; i++)
	{
        var row = listaProducto[i];
		Console.WriteLine($"{row.Nombre}: {row.Precio:C2}");
		
		if (i == 0)
		{
			max = row;
			min = row;
		}
		total += row.Precio;
		if (row.Precio > max.Precio)
			max = row;
		if (row.Precio < min.Precio)
			min = row;
	}
	Console.WriteLine("--------------");
    Console.WriteLine($"Importe total: {total:C2}");
    Console.WriteLine($"Producto con precio más alto -> {max.Nombre}: {max.Precio:C2}");
    Console.WriteLine($"Producto con precio más bajo -> {min.Nombre}: {min.Precio:C2}");

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

double ValidacionDouble()
{
	double valor = 0;
	while (!double.TryParse(Console.ReadLine(), out valor))
	{
		Console.WriteLine("Valor incorrecto");
	}
	return valor;
}

int ValidacionEntero()
{
    int valor = 0;
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor incorrecto");
    }
    return valor;
}*/
/*Crear una clase Ciudad con atributos: nombre y temperatura en °C. 
 * Permitir ingresar varias ciudades. Al terminar, mostrar:
Listado de todas las ciudades y su temperatura.
La ciudad con la temperatura más alta y la más baja.
La temperatura promedio de todas las ciudades.*/

List<Ciudad> listaCiudad = new List<Ciudad>();
while (true)
{
    Console.WriteLine("Ingresar un nueva ciudad? 1-Si / 2-No");
    if (Console.ReadLine() == "1")
    {
        Console.WriteLine("Ingrese el nombre");
        string nombre = ValidacionString();
        Console.WriteLine("Ingrese la temperatura");
        double temperatura = ValidacionDouble();
        listaCiudad.Add(new Ciudad() { Nombre = nombre, Temperatura = temperatura });
    }
    else
        break;
}
Resultados();
void Resultados()
{
    double total = 0;
    var max = new Ciudad();
    var min = new Ciudad();
    for (int i = 0; i < listaCiudad.Count; i++)
    {
        var row = listaCiudad[i];

        if (i == 0)
        {
            max = row;
            min = row;
        }
        total += row.Temperatura;
        if (row.Temperatura > max.Temperatura)
            max = row;
        if (row.Temperatura < min.Temperatura)
            min = row;
    }
    total = total / listaCiudad.Count;
    Console.WriteLine("--------------");
    Console.WriteLine($"Promedio de temperaturas: {total:N2}º");
    Console.WriteLine($"Ciudad con la temperatura más alta -> {max.Nombre}: {max.Temperatura:N2}º");
    Console.WriteLine($"Ciudad con la temperatura más baja -> {min.Nombre}: {min.Temperatura:N2}º");
}


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
