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

decimal desc5 = 0;
decimal desc10 = 0;

decimal valor;

if (total > 5000)
{
    if (total > 10000)
    {
        desc5 = (5000 * 5) / 100;

        desc10 = ((decimal)(total - 10000) * 10) / 100;
        valor = total - (desc5 + desc10);
    }
    else
    {
        desc5 = ((total - 5000) * 5) / 100;
        valor = total - desc5;
    }
    
}
else
{
    valor = total;
}
Console.Clear();
Console.WriteLine("Descuento  5% $" + desc5);
Console.WriteLine("Descuento 10% $" + desc10);
Console.WriteLine("-------------------");
Console.WriteLine("Total ------- $" + valor);
Console.ReadLine();


