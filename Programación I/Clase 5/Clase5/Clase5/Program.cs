Console.WriteLine("Ingrese la cantidad de vendedores");
int vendedores = Convert.ToInt32(Console.ReadLine());


decimal comisiones = 0;
decimal totalVenta = 0;
int sumaVentas = 0;



for (int i = 0; i < vendedores; i++)
{
    Console.Clear();
    Console.WriteLine($"Ingrese la cantidad ventas [Vendedor {i + 1}]");
    int ventas = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"Ingrese el total vendido [Vendedor {i + 1}]");
    decimal total = Convert.ToDecimal(Console.ReadLine());
    if (ventas <= 10)
    {
        comisiones = comisiones + (total * (decimal)0.03);
        totalVenta = totalVenta + total;
        sumaVentas = sumaVentas + ventas;
    }
    else if (ventas <= 20)
    {
        comisiones = comisiones + (total * (decimal)0.05);
        totalVenta = totalVenta + total;
        sumaVentas = sumaVentas + ventas;
    }
    else
    { 
        comisiones = comisiones + (total * (decimal)0.08);
        totalVenta = totalVenta + total;
        sumaVentas = sumaVentas + ventas;
    }
}
Console.Clear();
Console.WriteLine("Total de Productos:  " + sumaVentas);
Console.WriteLine("Total de Ventas:     $" + totalVenta);
Console.WriteLine("Total de comisiones: $" + comisiones);