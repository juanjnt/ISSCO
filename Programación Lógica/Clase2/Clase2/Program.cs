/*
 * Un desodorante de ambiente consume 1.5 ml 
 * por cada uso. Realiza un algoritmo donde el 
 * usuario pueda ingresar la capacidad del desodorante 
 * y mostrar la cantidad de uso que podrá realizar.
Un deportista de triatlón tiene sus tiempos establecidos en natación 4km/h, maratón 6km/h y ciclismo 43km/h, se desconoce el circuito que realiza y la distancia. Realizar un algoritmo que permita identificar el tipo de circuito y la distancia, luego mostrar el tiempo que tardaría el deportista en recorrer dicho circuito.
Una persona desea invertir en un plazo fijo su dinero por 30 días, el banco paga el 78% anual. Realizar un algoritmo que permita mostrar cuánto es el rendimiento y el importe total a cobrar.
Un comercio realiza descuentos de 10% para compras superiores a 10.000. Realiza un algoritmo para determinar si se le aplica descuento a la compra o no y mostrar que importe deberá abonar.
Una persona desea comprar dólares con pesos argentinos. Realiza un algoritmo que permita solicitar la valuación del dólar y la cantidad de dólares a comprar, mostrar que cantidad de pesos argentinos serán necesarios para dicha operación. 
El presupuesto de un municipio se compone del 45% sueldos, 20% salud, 10% educación, y 25% en gastos varios. Realizar un algoritmo que permita ingresar la cantidad de dinero disponible en el presupuesto y mostrar qué importe corresponde a cada área.
Un comercio larga una promoción de 3x2 en todos sus productos. Realice un algoritmo que permita cobrar, teniendo en cuenta que si el cliente compra 4 productos unos deberá cobrarse al precio normal y de esa forma deberá pagar por 3, mostrar el importe total a pagar.
Realice un algoritmo que muestre si una persona es mayor o menor de edad, se deberá solicitar la edad.
Una estudio de abogado se encarga de cobrar deudas, las deudas deben poseer más de 15 días de mora para poder ingresarlas al estudio, la cobranza se realiza en base a un 135% de interés anual por mora más  un 15% de honorarios por gestión de cobranzas. Realice un algoritmo que solicite el importe adeudado y los días de mora, si es mayor a 15 días calcular la mora y los honorarios para mostrar el importe total a cobrar.
Una concesionaria de autos paga a sus vendedores el 1.5% de comisión por venta de un modelo en particular más $135.000 de sueldo base. Realiza un algoritmo para mostrar el total a cobrar por el vendedor teniendo en cuenta la cantidad de ventas realizadas.*/




/*Un desodorante de ambiente consume 1.5 ml 
 * por cada uso. Realiza un algoritmo donde el 
 * usuario pueda ingresar la capacidad del desodorante 
 * y mostrar la cantidad de uso que podrá realizar.*/

/*
decimal desodorante = 0, cantidadUsos = 0, uso = (decimal)1.5;
Console.WriteLine("Ingrese la capacidad del desodorante en ml");
desodorante = decimal.Parse(Console.ReadLine());
while (desodorante >= uso)
{
    desodorante -= uso;
    cantidadUsos++;
}


Console.WriteLine($"Cantidad de usos: {cantidadUsos}, sobrante: {desodorante}");
*/


/*Un deportista de triatlón tiene sus tiempos 
 * establecidos en natación 4km/h, maratón 6km/h y 
 * ciclismo 43km/h, se desconoce el circuito que 
 * realiza y la distancia. Realizar un algoritmo 
 * que permita identificar el tipo de circuito y 
 * la distancia, luego mostrar el tiempo que 
 * tardaría el deportista en recorrer dicho circuito.*/
/*int distancia = 0;

Console.WriteLine("1- Natación // 2- Ciclismo // 3- Maratón");
string circuito = Console.ReadLine();
Console.WriteLine("Ingrese la distancia");
distancia = int.Parse(Console.ReadLine());
decimal tiempo = 0;
switch (circuito)
{
    case "1":
        tiempo = (decimal)distancia / (decimal)4;
        break;
    case "2":
        tiempo = (decimal)distancia / (decimal)6;
        break;
    case "3":;
        tiempo = (decimal)distancia / (decimal)43;
        break;
}
Console.WriteLine($"Tiempo en recorrer el circuito: {tiempo}");*/

/*Una persona desea invertir en un 
 * plazo fijo su dinero por 30 días, 
 * el banco paga el 78% anual. Realizar 
 * un algoritmo que permita mostrar 
 * cuánto es el rendimiento y el importe 
 * total a cobrar.*/
/*
const decimal tasa = ((decimal)78 / (decimal)365) * (decimal)30;
while (true)
{


    Console.WriteLine("Ingrese el importe a invertir");
    decimal importe = int.Parse(Console.ReadLine());
    decimal rendiminto = (importe * tasa) / (decimal)100;
    Console.WriteLine($"Rendimiento: ${rendiminto.ToString("N2")}, total a cobrar: ${(rendiminto + importe).ToString("N2")}");
}*/


/*Un comercio realiza descuentos de 10% 
 * para compras superiores a 10.000. 
 * Realiza un algoritmo para determinar 
 * si se le aplica descuento a la compra 
 * o no y mostrar que importe deberá abonar.*/
/*
decimal compra = 0;

Console.WriteLine("Ingrese el valor de la compra");
compra = decimal.Parse(Console.ReadLine());
if (compra > 10000)
{
    compra -= (compra * (decimal)10) / (decimal)100;
}
Console.WriteLine($"Importe total a pagar: {compra.ToString("N2")}");*/


/*Una persona desea comprar dólares con pesos argentinos. 
 * Realiza un algoritmo que permita solicitar la valuación
 * del dólar y la cantidad de dólares a comprar, mostrar 
 * que cantidad de pesos argentinos serán necesarios para 
 * dicha operación. 
*/
/*
decimal dolares = 0, cantDolares = 0, pesos = 0;

Console.WriteLine("Ingrese el precio del dolar");
dolares = decimal.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese la cantidad de dolares a comprar");
cantDolares = decimal.Parse(Console.ReadLine());
pesos = cantDolares * dolares;
Console.Clear();
Console.WriteLine($"Cantidad de pesos necesarios : ${pesos.ToString("N2")}");*/

/*El presupuesto de un municipio se compone del 45% sueldos, 
 * 20% salud, 10% educación, y 25% en gastos varios. 
 * Realizar un algoritmo que permita ingresar la cantidad 
 * de dinero disponible en el presupuesto y mostrar qué 
 * importe corresponde a cada área.*/

/*
decimal presupuesto = 0;
Console.WriteLine("Ingrese el importe del presupuesto");
presupuesto = decimal.Parse(Console.ReadLine());
Console.Clear();
decimal sueldo = (presupuesto * 45) / 100;
Console.WriteLine($"Partida correspondiente a sueldos: $ {sueldo.ToString("N2")}");
decimal salud =  (presupuesto * 20 ) / 100;
Console.WriteLine($"Partida correspondiente a salud: $ {salud.ToString("N2")}");
decimal educacion = (presupuesto * 10) / 100;
Console.WriteLine($"Partida correspondiente a educación: $ {educacion.ToString("N2")}");
decimal varios = (presupuesto * 25) / 100;
Console.WriteLine($"Partida correspondiente a gastos varios: $ {varios.ToString("N2")}");*/


/*Un comercio larga una promoción de 3x2 
 * en todos sus productos. Realice un algoritmo 
 * que permita cobrar, teniendo en cuenta que si 
 * el cliente compra 4 productos unos deberá 
 * cobrarse al precio normal y de esa forma 
 * deberá pagar por 3, mostrar el importe 
 * total a pagar.
*/

/*
decimal precio = 0, precioPromo = 0;
int cantidad = 0, fueraPromo = 0, cantPromo = 0;


Console.WriteLine("Ingrese el precio del producto");
precio = decimal.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese la cantidad comprada");
cantidad = int.Parse(Console.ReadLine());
Console.Clear();
precioPromo = precio * 2;
fueraPromo = cantidad % 3;
cantPromo = (cantidad - fueraPromo) / 3;
decimal totalFueraPromo = (decimal)fueraPromo * precio;
decimal totalPromo = (decimal)cantPromo * precioPromo;
decimal total = totalPromo + totalFueraPromo;
Console.WriteLine($"Producto precio normal ({fueraPromo}): $ {totalFueraPromo.ToString("N2")}");
Console.WriteLine($"Total en promo ({cantPromo}): $ {totalPromo.ToString("N2")}");
Console.WriteLine($"Total a pagar: ${total.ToString("N2")}");
*/


/*Realice un algoritmo que muestre si una 
 * persona es mayor o menor de edad, se 
 * deberá solicitar la edad.*/

/*
Console.WriteLine("Ingrese su edad");
string respuesta = "Es menor de edad";
Console.Clear();
if (int.Parse(Console.ReadLine()) > 18)
    respuesta  = "Es mayor de edad";
Console.WriteLine(respuesta);*/


/*Una estudio de abogado se encarga 
 * de cobrar deudas, las deudas deben 
 * poseer más de 15 días de mora para 
 * poder ingresarlas al estudio, 
 * la cobranza se realiza en base a 
 * un 135% de interés anual por mora 
 * más  un 15% de honorarios por gestión 
 * de cobranzas. Realice un algoritmo 
 * que solicite el importe adeudado y 
 * los días de mora, si es mayor a 15 
 * días calcular la mora y los honorarios 
 * para mostrar el importe total a cobrar.*/
/*
double deuda = 0;
int mora = 0;
double tasaDiaria = 135.0 / 365.0;
Console.WriteLine("Ingrese el importe adeudado");
deuda = double.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese los dias a mora");
mora = int.Parse(Console.ReadLine());
Console.Clear();
if (mora >= 15)
{
    double interes = (deuda * (mora * tasaDiaria)) / 100.0;
    Console.WriteLine($"Interes a cobrar: $ {interes.ToString("N2")}");
    double suma = deuda + interes;
    double honorarios = (suma * 15.0) / 100.0;
    Console.WriteLine($"Honorarios: $ {honorarios.ToString("N2")}");
    Console.WriteLine($"Total a cobrar: ${(suma + honorarios).ToString("N2")}");
}
else
{
    Console.WriteLine("No se gestiona deuda");
}*/

/*Una concesionaria de autos paga a sus 
 * vendedores el 1.5% de comisión por 
 * venta de un modelo en particular más 
 * $135.000 de sueldo base. Realiza un 
 * algoritmo para mostrar el total a 
 * cobrar por el vendedor teniendo en 
 * cuenta la cantidad de ventas realizadas.*/
/*
double precioAuto = 0;
int venta = 0;

Console.WriteLine("Ingrese el precio del auto");
precioAuto = double.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Ingrese la cantidad de autos vendidos");
venta = int.Parse(Console.ReadLine());
Console.Clear();
double com = (precioAuto * 1.5) / 100;
double total = (com * venta) + 135000;
Console.WriteLine($"Total a cobrar: ${total.ToString("N2")} ");*/
