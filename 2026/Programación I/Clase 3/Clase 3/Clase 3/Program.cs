/*Se conoce de antemano la cantidad de empleados a procesar 
 * (pedir dicho valor al usuario). 
 * Ingresar el sueldo bruto de cada empleado. 
 * Si el sueldo bruto supera los $500.000, 
 * aplicar un descuento por impuestos del 18%. 
 * Si es menor o igual, aplicar un descuento del 10%. 
 * Calcular y mostrar para cada empleado su sueldo neto. 
 * Al finalizar el ciclo, mostrar el sueldo neto promedio 
 * de todos los empleados procesados.*/


/*Console.WriteLine("Ingrese la cantidad de empleados a procesar: ");
int empleados = int.Parse(Console.ReadLine());
double totalSueldo = 0;
for (int i = 0; i < empleados; i++)
{
    Console.WriteLine($"Ingrese el sueldo bruto del empleado nº {i+1}");
    double sueldoBruto = Convert.ToDouble(Console.ReadLine());
    if (sueldoBruto > 500000)
    {
        sueldoBruto -= sueldoBruto * 0.15;
    }
    else
    {
        sueldoBruto -= sueldoBruto * 0.10;
    }
    Console.WriteLine($"El sueldo neto del empleado nº {i+1} es: {sueldoBruto:C2}");
    totalSueldo += sueldoBruto;
}
totalSueldo = totalSueldo / (double)empleados;
Console.WriteLine($"El sueldo neto promedio es de {totalSueldo:C2}");*/

/*Un comercio necesita procesar un lote fijo de 5 facturas.
 * Para cada factura, se debe pedir el monto base y los días 
 * de demora en el pago. Si los días de demora son mayores a 10, 
 * se aplica un recargo del 12% sobre el monto base. 
 * Si la demora es entre 1 y 10 días, el recargo es del 5%. 
 * Si no hay demora (0 días), no hay recargo. 
 * Mostrar el total a pagar por cada factura y, al final del programa, 
 * mostrar la suma total recaudada por concepto de recargos.*/

/*double totalRecargo = 0;
for (int i = 0; i < 5; i++)
{
    double recargo = 0;
    Console.WriteLine("Ingrese el monton base de la factura");
    double montoBase = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese los días de demora en el pago");
    int diasDemora = int.Parse(Console.ReadLine());
    if (diasDemora > 10)
    {
        recargo = montoBase * 0.12;
    }
    else if(diasDemora > 0 && diasDemora <= 10)
    {
        recargo = montoBase * 0.05;
    }
    totalRecargo += recargo;
    Console.WriteLine($"------DETALLE DEL COMPROBANTE Nº {i + 1}--------");
    Console.WriteLine($"Monto base: {montoBase:C2}");
    Console.WriteLine($"Recargo por {diasDemora} días: {recargo:C2}");
    Console.WriteLine($"Total a pagar: {(montoBase + recargo):C2}");
    Console.WriteLine("------------------------------------------");
}

Console.WriteLine($"Total recaudado en concepto de Recargo: {totalRecargo:C2}");*/

/*Pedir al usuario la cantidad total de turnos de trabajo a evaluar. Ingresar la 
 * cantidad de unidades producidas y la cantidad de unidades defectuosas de ese turno. 
 * Se debe calcular e informar el total de unidades aptas de ese turno (producidas menos defectuosas). 
 * Al finalizar todos los turnos, calcular el porcentaje global de producción defectuosa sobre la producción total.*/

/*Console.WriteLine("Ingrese la cantidad de turnos a evaluar");
int turnos = int.Parse(Console.ReadLine());
int producidas = 0;
int defectuosas = 0;
for (int i = 0; i < turnos; i++)
{
    Console.WriteLine("Ingrese la cantidad de unidades producidas");
    int producidasTurno = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la cantidad de unidades defectuosas");
    int defectuosasTurno = int.Parse(Console.ReadLine());
    int aptas = producidasTurno - defectuosasTurno;
    Console.WriteLine($"Total de unidades aptas en turno: {aptas}");

    producidas += producidasTurno;
    defectuosas += defectuosasTurno;
}

double porcentaje = (double)defectuosas * 100 / (double)producidas;
Console.WriteLine($"Porcentaje de producción total defectuosa: {porcentaje:N2}%");*/

/*Pedir el monto inicial de un crédito y la cantidad fija de meses a financiar. 
 * Simular mes a mes el avance de la deuda aplicando un interés mensual del 3% 
 * sobre el saldo acumulado del mes anterior. En cada mes, mostrar el número de mes, 
 * el monto del interés generado y el nuevo saldo total. Al finalizar, indicar cuánto 
 * fue el monto total pagado en concepto puro de intereses.*/

/*double montoInicial = 0;
Console.WriteLine("Ingrese el monto inicial a financiar");
montoInicial = double.Parse(Console.ReadLine());
int meses = 0;
Console.WriteLine("Ingrese la cantidad de meses a financiar");
meses = int.Parse(Console.ReadLine());
const double tasa = 0.03;

double totalAcumulado = montoInicial;
double interesAcumulado = 0;
for (int i = 0; i < meses; i++)
{
    double interesMensual = totalAcumulado * tasa;
    interesAcumulado += interesMensual;
    totalAcumulado += interesMensual;
    Console.WriteLine("===================");
    Console.WriteLine($"Resumen del mes {i + 1}");
    Console.WriteLine("===================");
    Console.WriteLine($"Interes mensual----{interesMensual:C2}");
    Console.WriteLine($"Saldo Acumulado----{totalAcumulado:C2}");
    Console.WriteLine("===================");
}

Console.WriteLine($"Concepto puro de interes-----{interesAcumulado:C2}");*/