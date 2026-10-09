using Actividad8.Ejercicio3;
using System.Runtime.InteropServices;

List<Empleado> listaEmpleados = new List<Empleado>();

while (true)
{
    var empleado = new Empleado();
    Console.WriteLine("Ingrese el Nº de legajo [0 para finalizar]");
    int legajo = 0;
    if (!int.TryParse(Console.ReadLine(), out legajo) || legajo < 0)
    {
        Console.WriteLine("Legajo inválido. Intente nuevamente.");
        continue;
    }
    else if (legajo == 0)
    {
        break;
    }
    else { empleado.Legajo = legajo; }

    Console.WriteLine("Ingrese el nombre del empleado");
    empleado.Nombre = Console.ReadLine();

    double sueldo = 0;
    while (true)
    {
        Console.WriteLine("Ingrese el sueldo base:");
        if (double.TryParse(Console.ReadLine(), out sueldo) && sueldo > 0)
        {
            empleado.SueldoBase = sueldo;
            break;
        }
        Console.WriteLine("Sueldo inválido. Intente nuevamente.");
        
    }
    listaEmpleados.Add(empleado);
    Console.WriteLine("Empleado registrado con éxito.");
}

try
{
    if (listaEmpleados.Count == 0)
    {
        throw new Exception("La lista de empleados está vacia");
    }
    Console.WriteLine("-------Lista de Empleados-------");
    var sueldoMax = new Empleado() { SueldoBase = 0};
    double totalSueldo = 0;
    foreach (var item in listaEmpleados)
    {
        if (item.SueldoBase > sueldoMax.SueldoBase)
        {
            sueldoMax = item;
        }
        totalSueldo += item.SueldoBase;
        Console.WriteLine($"Legajo Nº {item.Legajo} -> {item.Nombre}: ${item.SueldoBase:N2}");
    }

    Console.WriteLine("Empleado con sueldo más alto");
    Console.WriteLine($"Legajo Nº {sueldoMax.Legajo} -> {sueldoMax.Nombre}: ${sueldoMax.SueldoBase:N2}");
    Console.WriteLine($"Total gastado en sueldo: ${totalSueldo:N2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}