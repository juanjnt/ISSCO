/*Una perfumería registra las ventas diarias de sus vendedores. Cada vendedor recibe un 
 * salario fijo diario y además obtiene un bono del 10% sobre sus ventas.  

El programa debe:

Solicitar la cantidad total de vendedores.
Para cada vendedor, ingresar el total de ventas realizadas en el día.
Calcular cuánto será el bono (10% de las ventas) y el total a cobrar por 
ese vendedor (salario fijo + bono), si las ventas superan los $200.000 tiene 
un bono del 5% más en las ventas.
Mostrar cuánto debe cobrar cada vendedor.*/
/*
Console.WriteLine("Ingrese la cantidad total de vendedores:");
int vendedores = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el salario fijo diario:");
double salario = double.Parse(Console.ReadLine());
for (int i = 0; i < vendedores; i++)
{
	Console.WriteLine($"Ingrese el importe de ventas del Vendedor Nº{i + 1}");
	double ventas = double.Parse(Console.ReadLine());
	double bono = Bono(ventas);
	double total = salario + bono;
	Console.WriteLine($"El bono del vendedor Nº{i + 1} es: ${bono}");
    Console.WriteLine($"El vendedor Nº{i + 1} debe cobrar: ${total}");
}

double Bono(double ventas)
{
	double bono10 = ventas * 0.1;
    if (ventas >200000)
	{
		bono10 += ventas * 0.05;
    }
	return bono10;
}*/

/* Empresa láctea registra la cantidad de litros de leche entregados por cada 
 * productor en su campo durante un día. Cada productor recibe un pago fijo 
 * mínimo más un incentivo adicional del 8% sobre la cantidad de litros de leche entregada.

El programa debe:

Definir un precio para la leche
Para cada productor, ingresar la cantidad de litros entregados.
Calcular el incentivo (8% de litros entregados).
Determinar el pago total que recibe cada productor (pago fijo mínimo + total 
por litros + incentivo), si supera los 1.000 litros de leche se le paga 3% más por litro.
Mostrar cuánto recibe cada productor.
Al final, mostrar la cantidad total de litros entregados por todos los 
productores y el total en pago que realiza la empresa lactea en el día.*/


/*double litrosTotales = 0; double pagoTotal = 0;

Console.WriteLine("Ingrese el precio de la leche por litro:");
double precioLeche = double.Parse(Console.ReadLine());
bool continuar = true;
Console.WriteLine("Ingresar monto fijo de pago");
double pagoFijo = double.Parse(Console.ReadLine());
while (continuar)
{
	Console.WriteLine("Ingreser un nuevo productor? 1- Si 2- No");
	int opcion = int.Parse(Console.ReadLine());
	if (opcion == 1)
	{
		Console.WriteLine("Ingrese la cantidad de litros de leche");
		double litros = double.Parse(Console.ReadLine());
		litrosTotales += litros;
		double pagoProductor = PagoProducto(litros);
        pagoTotal += pagoFijo + pagoProductor;
		Console.WriteLine($"El productor debe cobrar: ${pagoFijo + pagoProductor}");
    }
	else
	{
		continuar = false;
		Console.WriteLine($"La cantidad total de litros entregados es: {litrosTotales} litros");
	    Console.WriteLine($"El total en pago que realiza la empresa láctea es: ${pagoTotal}");
    }
}

double PagoProducto(double litros)
{
	double pagoLeche = litros * precioLeche;
	double incentivo = pagoLeche * 0.08;
	if (litros > 1000)
	{
		incentivo += pagoLeche * 0.03;
    }
	return pagoLeche + incentivo;
}*/


/*3- Una concesionaria registra las ventas de autos en un día. Por cada venta, 
 * el vendedor recibe un comisión del 1.5% del precio del auto vendido, 
 * con más de 5 autos tiene un bono de $350.000

El programa debe:

Solicitar la cantidad total de autos vendidos.
Para cada venta, ingresar el precio del auto.
Calcular la comisión del vendedor (1.5% del precio).
Mostrar cuánto recibe el vendedor.*/

const double comision = 1.5, bono = 350000;
double total = 0;
Console.WriteLine("Ingrese la cantidad de autos vendidos:");
int autosVendidos = int.Parse(Console.ReadLine());

double ComisionAuto(double precio)
{
	return (precio * comision) / 100;
}

for (int i = 0; i < autosVendidos; i++)
{
	Console.WriteLine($"Ingrese el valor del auto Nº {i + 1}");
	double precioAuto = double.Parse(Console.ReadLine());
    double calculoComision = ComisionAuto(precioAuto);
    total += calculoComision;
}

if (autosVendidos > 5)	
	total += bono;
Console.WriteLine($"Total a cobrar: ${total.ToString("N2")}");
