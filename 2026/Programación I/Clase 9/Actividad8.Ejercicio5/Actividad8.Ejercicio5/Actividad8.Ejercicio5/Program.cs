using Actividad8.Ejercicio5;
using System.ComponentModel.Design;
using System.Xml.Serialization;

List<Mascota> listaMascota = new List<Mascota>();

Menu();

void Menu()
{
    Console.WriteLine("1- Agregar Mascota");
    Console.WriteLine("2- Filtrar Perros");
    Console.WriteLine("3- Filtrar Gatos");
    Console.WriteLine("4- Promedio de Edad");
    Console.WriteLine("5- Salir");

    int opcion = 0;
    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
    {
        Menu();
    }
    else
    {
        switch (opcion)
        {
            case 1:
                AgregarMascota();
                break;
            case 2:
                FiltroAnimales("perro");
                break;
            case 3:
                FiltroAnimales("gato");
                break;
                
            case 4:
                PromedioEdad();
                break;

        }
    }
}

void PromedioEdad()
{
    int edades = 0;
    foreach (var item in listaMascota)
    {
        edades += item.Edad;
    }
    edades = edades / listaMascota.Count;
    Console.WriteLine($"El promedio de edad de mascotas es de {edades} años");
    Menu();
}

void FiltroAnimales(string especie)
{
    try
    {
        var lista = new List<Mascota>();
        foreach (var item in listaMascota)
        {
            if (item.Especie.ToUpper() == especie.ToUpper())
            {

                lista.Add(item);
               
            }
        }
        if (listaMascota.Count == 0)
        {
            throw new Exception($"No existe ningun [{especie.ToUpper()}] en la lista");
        }
        else
        {
            foreach (var item in lista)
            {
                Console.WriteLine($"[{item.Especie}] {item.Nombre} - {item.Edad}");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Menu();
}


void AgregarMascota()
{
    Mascota mascota = new Mascota();
    Console.WriteLine("Ingrese la especie");
    mascota.Especie = Console.ReadLine();
    Console.WriteLine("Ingrese el nombre de la Mascota");
    mascota.Nombre = Console.ReadLine();
    while (true)
    {
        Console.WriteLine("Ingrese la edad");
        int edad = 0;
        if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0 && edad <= 30)
        {
            mascota.Edad = edad;
            break;
        }
        Console.WriteLine("Error en el valor ingresado");
    }
    listaMascota.Add(mascota);
    Menu();
}