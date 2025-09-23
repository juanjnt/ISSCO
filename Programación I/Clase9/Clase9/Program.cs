/*1- Se registran las ventas diarias de un local comercial.
Se deben ingresar ventas de forma indeterminada, calcular el total de ventas y el promedio por ventas
Si la venta supera los $100.000, obtiene un descuento del 15%.
2- Se desea realizar un programa en el cual se pueda fidelizar a quienes más viajan.
Ingresar la cantidad de viajes y el importe pagado en cada uno.
Mostrar el total pagado en viajes.
Si realizo más de 10 viajes o el importe gastado supera los 10.000 se realiza una devolución del 30%.
Mostrar importe a devolver.*/
/*
bool continuar = true;
double total = 0,  promedio = 0;
int cantidad = 0;
while (continuar)
{
    Console.WriteLine("Ingresar una nueva venta? 1- Si  2- No");
    if (int.Parse(Console.ReadLine()) == 1)
    {
        Console.WriteLine("Ingrese el importe de la venta");
        double venta = double.Parse(Console.ReadLine());
        venta = descuento(venta);
        Console.WriteLine($"Importe a pagar $ {venta.ToString("N2")}");
        total += venta;
        cantidad++;
    }
    else
    {
        continuar = false;
        Console.WriteLine($"Total recaudado ${total.ToString("N2")}");
        promedio = total / (double)cantidad;
        Console.WriteLine($"Promedio de venta ${promedio.ToString("N2")}");
        Console.WriteLine($"Total de ventas {cantidad}");
    }
}


double descuento(double venta)
{
    if (venta > 100000)
    {
        return venta * 0.85;
    }
    return venta;
}*/

/*2- Se desea realizar un programa en el cual se pueda fidelizar a quienes más viajan.
Ingresar la cantidad de viajes y el importe pagado en cada uno.
Mostrar el total pagado en viajes.
Si realizo más de 10 viajes o el importe gastado supera los 10.000 se realiza una devolución del 30%.
Mostrar importe a devolver.*/

Console.WriteLine("Ingrese la cantidad de viajes");
int viajes = int.Parse(Console.ReadLine());
double total= 0;

for (int i = 1; i <= viajes; i++)
{
    Console.WriteLine($"Ingrese el importe del viaje Nº{i}");
    total += double.Parse(Console.ReadLine());
}
Fidelizar();



void Fidelizar()
{
    if (total > 10000 || viajes > 10)
    {
        Console.WriteLine($"Corresponde devolución: ${(total * 0.3).ToString("N2")}");
         
    }
    else
    {
        Console.WriteLine("No corresponde devolución");
    }
}