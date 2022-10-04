/*Console.WriteLine("Ingrese la cantidad de días");
int dias = Convert.ToInt32(Console.ReadLine());


int segundos = dias * 24 * 60 * 60;
Console.WriteLine(segundos);*/

/*
Console.WriteLine("Ingrese la cantidad de feriados");
int feriados = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese la cantidad de domingo");
int domingos = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese la cantidad de días del mes");
int dias = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese el mes");
string mes = Console.ReadLine();

Console.Clear();
int litros = 23450;


dias = dias - feriados;
dias = dias - domingos;

int combustible = dias * litros;
combustible = combustible + ((litros / 2) * domingos);
Console.WriteLine("Cantidad de litros vendidos en " + mes + " " + combustible);*/

/*

Inicio();


void Inicio()
{
    Console.WriteLine("Ingrese el importe de su sueldo");
    decimal sueldo = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("El importe a cobrar con aumento es de " + Calculo(sueldo).ToString("C2"));
    Console.WriteLine("");
    Console.WriteLine("Enter para continuar");
    Console.ReadLine();
    Console.Clear();
    Inicio();
}



decimal Calculo(decimal sueldo)
{
    decimal calculo = sueldo;
    if (sueldo <= 50000)
    {
        calculo =  sueldo * (decimal)1.48;  
    }
    else if (sueldo > 50000 && sueldo <= 75000)
    {
        calculo = sueldo * (decimal)1.477;
    }
    else
    {
        calculo = sueldo * (decimal)1.503;
    }

    return calculo;
}
*/



Console.WriteLine("Ingrese primer destino");
string destino1 = Console.ReadLine();
Console.WriteLine("Ingrese el costo del pasaje");
decimal costo1 = Convert.ToDecimal(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese segundo destino");
string destino2 = Console.ReadLine();
Console.WriteLine("Ingrese el costo del pasaje");
decimal costo2 = Convert.ToDecimal(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese tercer destino");
string destino3 = Console.ReadLine();
Console.WriteLine("Ingrese el costo del pasaje");
decimal costo3 = Convert.ToDecimal(Console.ReadLine());
Console.Clear();


decimal pasaje = 0;
string destino = "";
decimal descuento = 0;


Venta();




void Venta()
{
    Pasaje();
    Cliente();

    Print("Pasaje con destino a " + destino);
    Print("Pasaje: --- " + pasaje.ToString("C2"));
    Print("Descuento:  " + descuento.ToString("C2"));
    Print("------------------------");
    Print("Total: ---- " + (pasaje - descuento).ToString("C2"));
    Print("");
    Print("");
    Print("Enter para continuar");
    Console.ReadLine();
    Console.Clear();
    Venta();
}
void Cliente()
{
    Print("Selecciones el tipo de pasajero");
    Print("1- Jubilado");
    Print("2- Estudiante");
    Print("3- Trabajador");
    Print("4- Normal");
    char val = Console.ReadKey().KeyChar;
    Console.Clear();

    if (val == (char)'1')
    {
        descuento = (pasaje * 60) / 100;
    }
    else if (val == (char)'2')
    {
        descuento = (pasaje * 35) / 100;
    }
    else if (val == (char)'3')
    {
        descuento = (pasaje * 25) / 100;
    }
    else if (val == (char)'4')
    {
        descuento = 0;
    }
    

    Console.Clear();

}

void Pasaje()
{
    Print("Selecciones el destino");
    Print($"1- {destino1} ($ {costo1.ToString("N2")})");
    Print($"2- {destino2} ($ {costo2.ToString("N2")})");
    Print($"3- {destino3} ($ {costo3.ToString("N2")})");
    char val = Console.ReadKey().KeyChar;
    Console.Clear();

    if (val == (char)'1')
    {
        pasaje = costo1;
        destino = destino1;
    }
    else if (val == (char)'2')
    {
        pasaje = costo2;
        destino = destino2;
    }
    else if (val == (char)'3')
    {
        pasaje = costo3;
        destino = destino3;
    }
   

    Console.Clear();
}

void Print(string val)
{
    Console.WriteLine(val);
}