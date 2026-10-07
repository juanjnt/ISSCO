

using Actividad8.Ejercicio2;
using System.ComponentModel.Design;
using System.Drawing;

//Producto producto = new Producto(12301, "Harina", 1500);


/*Producto arroz = new Producto() 
{
    Codigo = 12379,
    Nombre = "Arroz",
    Precio = 2000
};
Producto fideo = new Producto();
fideo.Nombre = "Fideo";
fideo.Codigo = 165;
fideo.Precio = 950;*/


List<Producto> listaProducto = new List<Producto>();
MenuInicial();

void MenuInicial()
{
    Console.Clear();
    int respuesta = 0;
    Console.WriteLine("1- Agregar un Producto");
    Console.WriteLine("2- Mostrar Catálogo");
    Console.WriteLine("3- Buscar producto por código");
    if (!int.TryParse(Console.ReadLine(), out respuesta))
    {
        Console.WriteLine("Solo se aceptan números [Enter para continuar]");
        Console.ReadLine();
        MenuInicial();
    }
    switch (respuesta)
    {
        case 1:
            AgregarProducto();
            break;
        case 2:
            MostrarCatalogo();
            break;
        case 3:
            BuscarProducto();
            break;
        default:
            MenuInicial();
            break;
    }
}

void BuscarProducto()
{
    Console.Clear();
    Console.WriteLine("Ingrese el código del producto a buscar");
    int valor = 0;
    if (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
    {
        Console.WriteLine("Valor incorrecto [Enter para continuar]");
        Console.ReadLine();
        BuscarProducto();

    }
    foreach (var item in listaProducto)
    {
        if (item.Codigo == valor)
        {
            Console.WriteLine("Producto encontrado");
            Console.WriteLine($"[{item.Codigo}] {item.Nombre} --> ${item.Precio:N2}");
            Console.WriteLine("[Enter para continuar]");
            Console.ReadLine();
            MenuInicial();
        }
    }

}

void MostrarCatalogo()
{
    foreach (var item in listaProducto)
    {
        Console.WriteLine($"[{item.Codigo}] {item.Nombre} --> ${item.Precio:N2}");
    }

    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    MenuInicial();
}

void AgregarProducto()
{
    Console.Clear();
    Producto producto = new Producto();
    producto.Codigo = ValidarCodigo();
    if (ExisteCodigo(producto.Codigo))
    {
        Console.WriteLine("El código ingresado, ya existe [Enter para continuar]");
        Console.ReadLine();
        AgregarProducto();
    }
    Console.WriteLine("Ingrese el nombre del producto");
    producto.Nombre = Console.ReadLine();
    producto.Precio = ValidaPrecio();
    listaProducto.Add(producto);
    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    MenuInicial();
}

bool ExisteCodigo(int codigo)
{
    foreach (var item in listaProducto)
    {
        if (codigo == item.Codigo)
        {
            return true;
        }
    }
    return false;
}


double ValidaPrecio()
{
    double valor = 0;
    while (true)
    {
        Console.WriteLine("Ingrese el precio del producto");
        if (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        {
            Console.WriteLine("Valor incorrecto");
        }
        else
        {
            break;
        }

    }
    return valor;
}

int ValidarCodigo()
{
    int valor = 0;
    while (true)
    {
        Console.WriteLine("Ingrese el código del producto");
        if (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        {
            Console.WriteLine("Valor incorrecto");
        }
        else
        {
            break;
        }

    }
    return valor;
}