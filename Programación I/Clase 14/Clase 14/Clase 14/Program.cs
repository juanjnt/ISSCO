decimal importe = 0;

decimal contado = 0;
decimal ctaCte = 0;


Inicio();

void Inicio()
{
    Console.WriteLine("Ingrese el importe de la compra");
    importe = Convert.ToDecimal(Console.ReadLine());
    Console.Clear();
    TipoVenta();

}


void TipoVenta()
{
    Print("Forma de pago");
    Print("1- Contado");
    Print("2- Cuenta Corriente");
    Print("3- Mixta");
    char val = Console.ReadKey().KeyChar;
    Console.Clear();

    if (val == (char)'1')
    {
        contado = importe;
        Detalle();
    }
    else if (val == (char)'2')
    {
        ctaCte = importe;
        Detalle();
    }
    else if (val == (char)'3')
    {
        Mixta();
    }
    

    Console.Clear();

}

void Mixta()
{
    Console.Clear();
    Print("Elija calculo de venta");
    Print("1- Porcentaje");
    Print("2- Monto Fijo");
    char val = Console.ReadKey().KeyChar;
    Console.Clear();
    if (val == (char)'1')
    {
        Print("Ingrese el porcentaje de contado");
        decimal porcentaje = Convert.ToDecimal(Console.ReadLine());
        contado = (importe * porcentaje) / 100;
        ctaCte = importe - contado;
        Detalle();
    }
    else if (val == (char)'2')
    {
        Print("Ingrese el importe fijo de contado");
        contado = Convert.ToDecimal(Console.ReadLine());
        ctaCte = importe - contado;
        Detalle();
    }
    Console.Clear();
}




void Print(string txt)
{ 
    Console.WriteLine(txt);

}


void Detalle()
{
    Console.Clear();
    
    decimal interes = ctaCte * (decimal)0.07;
    ctaCte = ctaCte + interes;
    decimal total = contado + ctaCte;
    Print("Importe de Contado.....$" + contado.ToString("N2"));
    Print("Importe de Cta Cte.....$" + ctaCte.ToString("N2"));
    Print("Importe de Interes.....$" + interes.ToString("N2"));
    Print("----------------------------------------------");
    Print("Importe Total..........$" + total.ToString("N2"));
    Print("");
    Print("Enter para continuar");
    Console.ReadLine();
    Console.Clear();
    Inicio();
}