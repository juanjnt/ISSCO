/*Console.WriteLine("Ingrese nota examen escrito");
int nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese nota examen oral");
int nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese nota conceptual");
int nota3 = Convert.ToInt32(Console.ReadLine());


//70 % escrito, 10% oral, 20% conceptual

decimal resultado1 = nota1 * (decimal)0.7;
decimal resultado2 = nota2 * (decimal)0.1;
decimal resultado3 = nota3 * (decimal)0.2;

decimal resultadoTotal = resultado1 + resultado2 + resultado3;
Console.WriteLine("Nota final " + (int)resultadoTotal);
Console.WriteLine("Nota final " + resultadoTotal);*/


//venta de sillas, si vendo más $5000 descuento de %5
//(para solo el valor que supere los $5000) y si vendo más
//de $10000 descuento del 10% (para solo el valor que supere los $10000)
//ejemplo para $15000, de $5001 a $10000 5% y de $10001 para arriba 10%

Console.WriteLine("Ingrese el total de la venta");
decimal total = Convert.ToDecimal(Console.ReadLine());

decimal total5 = total - 5000;
decimal total10 = total - 10000;
decimal desc5;
decimal desc10;
if (total5 > 0)
{
    desc5 = (total5 * 5) / 100;
    if (desc5 > )
    {

    }
}

