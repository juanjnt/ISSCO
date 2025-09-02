/*Realiza un algoritmo que calcule la propina que corresponde 
 * dejar en un restaurante Solicita al usuario el total de la cuenta 
 * y el porcentaje de propina deseado. Muestra la propina y el total 
 * a pagar (cuenta + propina).*/

/*
Console.WriteLine("Ingrese el total de la cuenta");
double cuenta = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de la propina");
double propina = double.Parse(Console.ReadLine());
propina = (cuenta * propina) / 100;

Console.WriteLine($"Total de la cuenta: ${(cuenta + propina):N2}");
Console.WriteLine($"Propina: ${propina:N2}");*/






/*
Una empresa que tiene servicio de delivery de diversos productos 
cataloga a sus clientes como "regular" "frecuente" o "vip" de 
acuerdo a los pedidos que realizan por su aplicación. Realiza un 
algoritmo que solicite la cantidad de pedidos realizadas y clasifique 
al cliente. Regular (1-7 pedidos), Frecuente (8-20 pedidos), 
VIP (más de 20 pedidos).
*/
/*
while (true)
{
    int pedidos = 0;

    Console.WriteLine("Ingrese la cantidad de pedidos");
    pedidos = int.Parse(Console.ReadLine());

    if (pedidos >= 1 && pedidos <= 7)
        Print("Regular");
    else if (pedidos >= 8 && pedidos <= 20)
        Print("Frecuente");
    else
        Print("VIP");


}

void Print(string tipoDeCliene)
{
    Console.WriteLine($"Tipo de cliente {tipoDeCliene}");
}*/







/*
Un empleado recibirá un aumento del 10.5% si su salario es 
menor a $750000 y del 7% si es mayor. Realiza un algoritmo 
que solicite el sueldo del empleado y determine el nuevo 
salario después del aumento mostrar el total a cobrar por el empleado
 */
/*
Console.WriteLine("Ingrese el salario");
double salario = double.Parse(Console.ReadLine());
if (salario < 750000)
{
    salario = salario * 1.105;
}
else
{
    salario = salario * 1.07;
}
Console.WriteLine($"Total a cobrar con aumento: ${salario:N2}");*/


/*Una compañía eléctrica aplica un descuento del 11,7% en la tarifa 
 * mensual si el consumo es menor a 97.5kWh. Realiza un algoritmo 
 * que solicite el consumo actual y calcule el total a pagar, 
 * considerando si se aplica o no el descuento.
*/
/*
Console.WriteLine("Ingrese el consumo de energia");
double consumo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor del kwh");
double kwh = double.Parse(Console.ReadLine());
double tarifa = consumo * kwh;

if (consumo < 97.5)
{
    tarifa -= tarifa * 0.117;
}
Console.WriteLine($"Total a pagar {tarifa:N2}");
*/


/*
Realiza un algoritmo que solicite al usuario que adivine un 
número secreto. Se permite ingresar hasta 5 intentos y se 
debe informar si acertó o no.
*/
/*
Console.WriteLine("Indentifique su Algoritmo");
Console.Title = Console.ReadLine();
Console.Clear();

Console.WriteLine("Ingrese un número");
int numero = int.Parse(Console.ReadLine());
Console.Clear();
bool gano = false;
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine($" Oportunidad {i}:");
    if (numero == int.Parse(Console.ReadLine()))
    {
        Console.WriteLine("Número correcto!!");
        gano = true;
        break;
    }
    else
    {
        Console.WriteLine("Número incorrecto!!");
    }
}
if (!gano)
{
    Console.WriteLine("Perdiste! fin de los intentos");
}
*/



/*Extra 
/*
Realiza un algoritmo que permita ingresar montos de compras 
hasta que el usuario ingrese 0. Muestra la suma total de compras al final.
 */
/*
double compraTotal = 0, compra = 1;

while (compra > 0)
{
    Console.WriteLine("Ingrese el importe de su compra");
    compra = double.Parse(Console.ReadLine());
    compraTotal += compra;
}

Console.WriteLine($"Total comprado: ${compraTotal:N2}");
*/

/*
Un servicio de mensajería cobra por el peso del paquete: $2700 
por kilogramo. Si el peso es superior a 12 kg aplica un costo 
adicional de $378 por kilogramo. Realiza un algoritmo que determine 
el costo de envío total.*/
/*
const double precio = 2700, adicional = 3078;
double total = 0;

Console.WriteLine("Ingrese el peso del paquete");
double kilos = double.Parse(Console.ReadLine());
if (kilos > 12)
{
    double extra = kilos - 12;
    total = extra * adicional;
    total += 12 * precio;
}
else
{
    total = kilos * precio;
}
Console.WriteLine($"Total por envio: ${total:N2}");*/