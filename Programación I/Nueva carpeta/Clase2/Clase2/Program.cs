using Clase2;


/*
var personaConsola = new Persona();
Console.WriteLine("Ingrese un nombre");
personaConsola.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese un apellido");
personaConsola.Apellido = Console.ReadLine();

DateTime valor;
while (true)
{
    Console.WriteLine("Ingrese una fecha de nacimiento dd/mm/aaaa");
    string fecha = Console.ReadLine();
    if (!DateTime.TryParse(fecha, out valor))
        Console.WriteLine("Valor ingresado para fecha de nacimiento es incorrecto");
    else  
        break;
}
personaConsola.Nacimiento = valor;
list.Add(personaConsola);
int num;
while (true)
{
    Console.WriteLine("Ingrese un número de documento");
    string entero = Console.ReadLine();
    if (!int.TryParse(entero, out num))
        Console.WriteLine("Valor ingresado para dni es incorrecto");
    else
        break;
}
personaConsola.Dni = num;

Persona persona = new Persona() { Nombre = "Roberto", Apellido = "Sosa",
    Nacimiento = Convert.ToDateTime("17/09/1981"), Dni = 29245875 };
list.Add(persona);

var pers = new Persona() { Nombre = "Juan", Apellido = "Gomez"};
list.Add(pers);
var persona1 = new Persona();
persona1.Nombre = "Juliana";
persona1.Apellido = "Perez";
persona1.Dni = 31233213;
persona1.Nacimiento = new DateTime(1985, 08, 23);
list.Add(persona1);

*/



List<Persona> list = new List<Persona>();
var lista = new List<Persona>();
var pers = new Persona();
var stringLista = new List<int>();
List<string> listaString = new List<string>();

string nombre1, nombre2, nombre3, nombre4, apellido1, apellido2, apellido3, apellido4;
DateTime nacimiento1, nacimiento2, nacimiento3, nacimiento4;
int dni1, dni2, dni3, dni4;

var persona1 = new Persona();
var persona2 = new Persona();
var persona3 = new Persona();
var persona4 = new Persona();

foreach (var item in list)
{
    Console.WriteLine($"Nombre: {item.Apellido}, {item.Nombre} // Nacimiento: " +
        $"{item.Nacimiento.ToString("dd/MM/yyyy")} // Dni Nº: {item.Dni}");
}






