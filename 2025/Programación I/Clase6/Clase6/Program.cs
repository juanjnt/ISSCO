/*Se debe realizar un programa que permita:
Elegir entre varias promociones (10%, 15%, 20%), o sin promoción.
Ingresar el precio original del producto.
Calcular el precio final después del descuento.
Mostrar el resultado.
Repetir hasta que el usuario decida salir del programa.
Incluye un menú para seleccionar la promoción.*/
/*
Console.WriteLine("Ingrese el precio del producto:");
double precio = Convert.ToDouble(Console.ReadLine());
MenuInicial();
void MenuInicial()
{
    Console.Clear();
    Console.WriteLine("Ingresar nueva venta? 1- Si 2-No");
    int opcion = Convert.ToInt32(Console.ReadLine());
    if (opcion == 1)
    {
        MenuPromociones();
    }
}

void MenuPromociones()
{
    Console.Clear();
    Console.WriteLine("Seleccione una promoción:");
    Console.WriteLine("1. 10% de descuento");
    Console.WriteLine("2. 15% de descuento");
    Console.WriteLine("3. 20% de descuento");
    Console.WriteLine("4. Sin promoción");
    Console.WriteLine("5. Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Precio final con 10% de descuento: {CalcularDescuento(precio, 10)}");
            break;
        case 2:
            Console.WriteLine($"Precio final con 15% de descuento: {CalcularDescuento(precio, 15)}");
            break;
        case 3:
            Console.WriteLine($"Precio final con 20% de descuento: {CalcularDescuento(precio, 20)}");
            break;
        case 4:
            Console.WriteLine($"Precio final sin descuento: {precio}");
            break;
        case 5:
            MenuInicial();
            break;
        default:
            MenuInicial();
            break;
    }
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadLine();
    MenuInicial();
}

string CalcularDescuento(double precio, double descuento)
{
    return (precio - (precio * descuento / 100)).ToString("N2");
}*/


/*Un usuario ingresa su consumo mensual en kWh. 
 * El programa debe: Solicitar el precio el kwh.
Si el consumo supera los 300 kWh, 
aplicar un 10% de recargo al precio.
Si el consumo está entre 100 y 300 kWh, 
aplicar un descuento del 5% en la tarifa base.
Mostrar el importe final del consumo.
Permitir hacer varias consultas hasta que el 
usuario decida salir mediante un menú.*/
/*
Console.WriteLine("Ingrese el precio del KWH");
double precio = double.Parse(Console.ReadLine());
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Desea ingresar un nuevo calculo? 1- Si  2- No");
    int opciones = int.Parse(Console.ReadLine());
    if (opciones == 1)
    {
        Console.WriteLine("Ingrese el consumo");
        double consumo = double.Parse(Console.ReadLine());
        double total = consumo * precio;
        if (consumo > 300)
        {
            total += Porcentaje(total, 10);
            Console.WriteLine($"Importe total consumido en {consumo} Kwh, ${total}");
        }
        else if (consumo <= 300 && consumo > 100)
        {
            total -= Porcentaje(total, 5);
            Console.WriteLine($"Importe total consumido en {consumo} Kwh, ${total}");
        }
        else
        {
            Console.WriteLine($"Importe total consumido en {consumo} Kwh, ${total}");
        }
    }
    else
    {
        continuar = false;
    }
}


double Porcentaje(double importe, double porcentaje)
{
    porcentaje = (importe * porcentaje / 100);
    return porcentaje;
}*/



/*Una tienda ofrece descuentos dependiendo de la cantidad 
 * de productos comprados y del método de pago, solo vende 
 * un producto:

Si compras más de 5 productos, obtienes un descuento del 10%.
Si pagas en efectivo, adicionalmente recibes un 10% de descuento 
sobre el precio final.
Si pagas con tarjeta en un pago, no hay descuento adicional, 
en cuotas se le suma un 3% por cuota (ejemplo 3 cuotas 9%)
El programa debe:

Solicitar el precio unitario del producto.
Solicitar al usuario el número de productos que desea comprar.
Calcular el precio total sin descuentos ni intereses.
Aplicar el descuento del 10% si corresponde.
Preguntar el método de pago y, si es efectivo, aplicar el 
descuento adicional, si es tarjeta en cuotas preguntar las cuotas.
Mostrar el precio final a pagar detallado, total, 
descuento, interés, importe a pagar.*/


Console.WriteLine("Ingrese el precio del producto");
double precio = double.Parse(Console.ReadLine());
double descuento = 0, interes = 0; int cantidad = 0;

while (true)
{
    descuento = 0; interes = 0; cantidad = 0;
    Console.WriteLine("Ingrese la cantidad de productos a comprar");
    cantidad = int.Parse(Console.ReadLine());
    
    DescuentoCantidad();
    Console.WriteLine("Ingrese medio de pago");
    Console.WriteLine("1- Tarjeta");
    Console.WriteLine("2- Efectivo");
    int opciones = int.Parse(Console.ReadLine());
    if (opciones == 1)
    {
        Console.WriteLine("Ingrese la cantidad de cuotas 1 a 12");
        int cuotas = int.Parse(Console.ReadLine());
        if (cuotas == 1)
        {
            Resultado();
        }
        else
        {
            double total = ((double)cantidad * precio) - descuento;
            interes += Porcentaje(total, Tarjeta(cuotas));
            Resultado();
        }
    }
    else
    {
        double total = ((double)cantidad * precio) - descuento;
        descuento += Porcentaje(total, 10);
        Resultado();
    }
}




void DescuentoCantidad()
{
    if (cantidad > 5)
    {
        descuento += ((precio * (double)cantidad) * 10.0) / 100.0;
    }
}

void Resultado()
{
    double total = (precio * (double)cantidad);
    double pagar = total + interes - descuento;
    Console.WriteLine($"Importe total: ${total.ToString("N2")}");
    Console.WriteLine($"Descuento total: ${descuento.ToString("N2")}");
    Console.WriteLine($"Interes total: $ {interes.ToString("N2")}");
    Console.WriteLine($"Total a pagar: ${pagar.ToString("N2")}");

}



double Tarjeta(int cuotas)
{
    return 3.0 * (double)cuotas;
}


double Porcentaje(double importe, double indice)
{
    return (importe * indice) / 100;
}

