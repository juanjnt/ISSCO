/*
4- Un banco implemente un sistema de inversiones, 
el usuario necesita saber cuales son las ganancia de acuerdo a las opciones, 
se obtiene un interes del 35% anual a entre 30 y 59 días, 
un interes del 40% anual entre 60 y 89 días y para 90 o más 43% anual.
El usuario ingresa el monto a invertir en pesos.
Calcular cuánto tendrá al final de un año si se capitaliza anualmente.
Mostrar monto final en pesos argentinos.
 
 */


using System.Diagnostics;

double importe = 0, tasa = 0,  pago = 0;


void DatosIniciales()
{
    while (importe == 0)
    {
        Console.WriteLine("Ingrese el importe a invertir");
        importe = ValidarNumero(Console.ReadLine());
    }
    while (tasa == 0)
    {
        Console.WriteLine("Ingrese la tasa de interes");
        tasa = ValidarNumero(Console.ReadLine());
    }
}


List<string> menu = new List<string>() { "Simular", "Invertir", "Salir" };
MenuListaValidado(menu);
MenuPrincipal();
Console.WriteLine($"Total pagado: ${pago.ToString("N2")}");

void MenuPrincipal()
{
    Console.Clear();
    List<string> menu = new List<string>() { "Simular", "Invertir", "Salir" };
    int respuesta = MenuLista(menu);
    switch (respuesta)
    {
        case 1:
            MenuCalculo(true);
            break;
        case 2:
            MenuCalculo(false);
            break;
        default:
            break;
    }
}

void ResultadoCalculo(int respuesta, int dias,  double importe, bool simular)
{
    switch (respuesta)
    {
        case 1:
            importe = CalculoDeInversion(dias, 35, importe);
            break;
        case 2:
            importe = CalculoDeInversion(dias, 40, importe);
            break;
        case 3:
            importe = CalculoDeInversion(dias, 43, importe);
            break;
        case 4:
            MenuPrincipal();
            break;
        default:
            break;
    }
    if (!simular)
    {
        pago += importe;
    }
    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    MenuPrincipal();


}


void MenuCalculo(bool simular)
{
    Console.Clear();
    List<string> menu = new List<string>() { "35% 30 a 59 días", "40% 60 a 89 días", "43% más 90 días", "Volver" };
    int respuesta = MenuLista(menu);
    int diasCalculo = 0;
    while (diasCalculo == 0)
    {
        Console.WriteLine("Ingrese los días a invertir");
        diasCalculo = ValidarEntero(Console.ReadLine());
    }
    double importeInvertir = 0;
    while (importeInvertir == 0)
    {
        Console.WriteLine("Ingrese el importe a invertir");
        importeInvertir = ValidarNumero(Console.ReadLine());
    }

    ResultadoCalculo(respuesta, diasCalculo, importeInvertir, simular);
}


double CalculoDeInversion(int dias, double porcentaje, double importe)
{
    double tasa = (porcentaje / 365.0) * (double)dias;
    double ganancia = (tasa * importe) / 100;
    Console.WriteLine($"Ganancia calculada: {ganancia.ToString("N2")}");
    return ganancia;
}


int MenuLista(List<string> lista)
{
    for (int i = 0; i < lista.Count; i++)
    {
        Console.WriteLine($"{i+1}- {lista[i]}");
    }
    int valor = 0;
    while (valor == 0)
    {
        Console.WriteLine("Seleccione una opción");
        valor = ValidarEntero(Console.ReadLine());
    }
    return valor;
}


double ValidarNumero(string valor)
{
    double num;
    if (!double.TryParse(valor, out num))
    {
        Console.Clear();
        Console.WriteLine("Error al convertir el número");
        return num;
    }
    return num;
}


int ValidarEntero(string valor)
{
    int num;
    if (!int.TryParse(valor, out num))
    {
        Console.WriteLine("Error al convertir el número");
        return num;
    }
    return num;
}


void MenuListaValidado(List<string> lista)
{
    for (int i = 0; i < lista.Count; i++)
    {
        Console.WriteLine($"{i + 1}- {lista[i]}");
    }
    int valor = 0;
    if (!int.TryParse(Console.ReadLine(), out valor))
    {
        MenuListaValidado(lista);
    }
    switch (valor)
    {
        case 1:
            Console.WriteLine("Opción 1");
            break;
        case 2:
            Console.WriteLine("Opción 2");
            break;
        case 3:
            Console.WriteLine("Opción 3");
            break;
        default:
            MenuListaValidado(lista);
            break;
    }
}