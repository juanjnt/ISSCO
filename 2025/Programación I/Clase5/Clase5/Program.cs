/*Se necesita una calculadora de descuentos, el programa debe 
 * realizar los siguientes cálculos:
Calcular el precio final con un descuento del 20% si la compra es mayor a $100000.
Calcular el precio final con un recargo del 5% si la compra es menor o igual a $10000.
Calcular el precio final con un recargo del 10% para el resto.
El usuario ingresa el precio de compra y el programa muestra el precio 
final según el monto de la compra. El proceso se repite hasta que elija salir.*/
/*
bool continuar = true;


while (continuar)
{
    Console.WriteLine("Ingresar nueva venta? 1-Si  2-No");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 1)
    {
        Console.WriteLine("Ingrese el precio de compra:");
        double precio = double.Parse(Console.ReadLine());
        if (precio > 100000)
        { 
            Console.WriteLine(Porcentaje(precio, 20));
        }
        else if (precio <= 10000)
        {
            Console.WriteLine(Porcentaje(precio, 5));
        }
        else
        {
            Console.WriteLine(Porcentaje(precio, 10));
        }
    }
}

string Porcentaje(double precio, double indice)
{
    string respuesta = $"El precio final con descuento del {indice}% es: $";
    double calculo = (precio * indice) / 100;
    respuesta += (precio - calculo).ToString("N2");
    return respuesta;
}*/

/*2- Se ingresa la cantidad de alumnos que hay en una clase. 
 * Para cada alumno, ingresar su nota (de 0 a 100).
El programa debe:
Calcular el promedio general.
Contar cuántos alumnos aprobaron (nota >= 60) y cuántos reprobados.
Mostrar los porcentajes de aprobados y reprobados respecto al total.
Salir.*/


//Console.WriteLine("Ingrese la cantidad de alumnos:");
//int cantidadAlumnos = int.Parse(Console.ReadLine());

List<string> opciones = new List<string>()
{
    "Ingresar notas",
    "Calcular promedio general",
    "Contar aprobados y reprobados",
    "Mostrar porcentajes de aprobados y reprobados",
    "Salir"
};
List<int> listaNotas = new List<int>();
Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("Seleccione una opción:");
    for (int i = 0; i < opciones.Count; i++)
    {
        Console.WriteLine($"{i} - {opciones[i]}");
    }
    int seleccion = int.Parse(Console.ReadLine());
    switch (seleccion)
    {
        case 0:
            CargarNota();
            break;
        case 1:
            double promedio = PromedioGeneral();
            Console.WriteLine($"El promedio general es: {promedio.ToString("N2")} [Enter para continuar]");
            Console.ReadLine();
            Menu();
            break;
        case 2:
            ContarNotasPromedio(false);
            break;
        case 3:
            ContarNotasPromedio(true);
            break;
        case 4:
            break;
        default:
            Menu();
            break;
    }
}
/*
void ContarNotas()
{
    int aprobados = 0;
    int reprobados = 0;
    foreach (int nota in listaNotas)
    {
        if (nota >= 60)
        {
            aprobados++;
        }
        else
        {
            reprobados++;
        }
    }
    Console.WriteLine($"Aprobados: {aprobados}, Reprobados: {reprobados}");
    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    Menu();
}*/

void ContarNotasPromedio(bool promedio)
{
    int aprobados = 0;
    int reprobados = 0;
    double promedioAprobado = 0;
    double promedioReprobado = 0;
    foreach (int nota in listaNotas)
    {
        if (nota >= 60)
        {
            aprobados++;
            promedioAprobado += nota;
        }
        else
        {
            reprobados++;
            promedioReprobado += nota;
        }
    }
    promedioAprobado = promedioAprobado / (double)aprobados;
    promedioReprobado = promedioReprobado / (double)reprobados;
    if (promedio)
    {
        Console.WriteLine($"PROMEDIOS -> Aprobados: {promedioAprobado}, Reprobados: {promedioReprobado}");
    }
    else
    {
        Console.WriteLine($"CANTIDADES -> Aprobados: {aprobados}, Reprobados: {reprobados}");
    }

    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    Menu();
}

double PromedioGeneral()
{
    double promedio = 0;
    foreach (int nota in listaNotas)
    {
        promedio += nota;
    }
    promedio = promedio / (double)listaNotas.Count;
    return promedio;
}

void CargarNota()
{
    //listaNotas.Clear();
    Console.Clear();
    //for (int i = 0; i < cantidadAlumnos; i++)
    //{
    Console.WriteLine("Ingrese una nueva nota");
    int nota = int.Parse(Console.ReadLine());
    listaNotas.Add(nota);
    //}
    Menu();
}


