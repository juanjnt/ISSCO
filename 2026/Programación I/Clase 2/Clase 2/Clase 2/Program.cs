/*int numero = 10;
while (numero >= 0)
{
    Console.WriteLine($"El número es: {numero}");
    numero--;
    //numero = numero - 1;
}
Console.WriteLine($"¡Fin del bucle! {numero}");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"El número es: {i}");

}


int promedio = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Ingrese la nota del alumno {i}");
    int nota  = int.Parse(Console.ReadLine());
    promedio += nota;
    //promedio = promedio + nota;
}
promedio = promedio / 5;
Console.WriteLine($"El promedio de las notas es: {promedio}");
*/

/*1- Definir un saldo inicial de 5000000. 
 * Permitir al usuario realizar retiros de 
 * dinero dentro de un bucle while siempre 
 * que el monto ingresado sea mayor a 0. 
 * El bucle debe terminar inmediatamente 
 * si el saldo llega a 0 o si el usuario 
 * ingresa un monto menor o igual a 0. 
 * En cada extracción, restar el monto y 
 * mostrar el saldo restante.*/

/*decimal saldo = 5000000;
while (saldo > 0)
{
    Console.WriteLine("Ingrese el monto a retirar");
    decimal retiro = decimal.Parse(Console.ReadLine());
    if (retiro <= saldo && retiro > 0)
    {
        saldo -= retiro;
        Console.WriteLine($"Saldo restante : ${saldo:N2}");
    }
    else if (retiro > saldo && saldo > 0)
    {
        Console.WriteLine("Fondos insuficientes");
    }
    else if (retiro <= 0)
    {
        Console.WriteLine("Monto inválido, el retiro debe ser mayor a 0");
        break;
    }
}
Console.WriteLine($"Saldo restante : ${saldo:N2}");*/


/*2- Pedir de forma continua la edad de los alumnos que van ingresando al aula. 
 * El bucle while termina cuando se ingresa una edad igual a 0. Calcular y mostrar 
 * al final la cantidad total de alumnos presentes y el promedio exacto de edad de los asistentes.*/

/*
int totalAlumnos = 0;
int sumaEdades = 0;

Console.Write("Ingrese la edad del alumno (0 para terminar): ");
int edad = int.Parse(Console.ReadLine());

while (edad != 0)
{
    if (edad > 0)
    {
        sumaEdades += edad;
        totalAlumnos++;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese una edad válida.");
    }

    Console.Write("Ingrese la edad del siguiente alumno (0 para terminar): ");
    int edadAlumno = int.Parse(Console.ReadLine());
}


Console.WriteLine($"Total de alumnos presentes: {totalAlumnos}");

if (totalAlumnos > 0)
{
    // Se realiza el casteo a double para obtener el promedio exacto con decimales
    double promedio = (double)sumaEdades / totalAlumnos;
    Console.WriteLine($"Promedio de edad: {promedio:N2} años");
}
else
{
    Console.WriteLine("No se ingresaron alumnos al aula.");
}*/


/*3- Ingresar los precios de los productos uno por uno en un bucle while. El bucle 
 * finaliza cuando el precio ingresado sea 0. Calcular el total. Si el total acumulado 
 * es mayor a 15000, aplicar un descuento del 15% e imprimir el total final con descuento. 
 * Si es menor o igual, mostrar el total sin modificaciones.
*/
/*
decimal total = 0;

Console.Write("Ingrese el precio del producto (0 para terminar): ");
decimal precio = decimal.Parse(Console.ReadLine());

while (precio != 0)
{
    if (precio > 0)
    {
        total += precio;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un precio válido.");
    }

    Console.Write("Ingrese el precio del siguiente producto (0 para terminar): ");
    precio = decimal.Parse(Console.ReadLine());
}

Console.WriteLine($"Total acumulado: ${total:N2}");

if (total > 15000)
{
    decimal descuento = total * 0.15m;
    decimal totalFinal = total - descuento;

    Console.WriteLine($"Se aplicó un descuento del 15% (-${descuento:N2})");
    Console.WriteLine($"Total final a pagar: ${totalFinal:N2}");
}
else
{
    Console.WriteLine($"Total final a pagar: ${total:N2}");
}*/

/*​4- Pedir inicialmente el stockDisponible de un producto. Luego, mediante un bucle while, 
 * permitir realizar solicitudes de retiro ingresando la cantidadCantidad. Mientras la cantidadCantidad 
 * sea menor o igual al stockDisponible, restar la cantidad del stock y mostrar el nuevo stock. 
 * Si en alguna solicitud la cantidad supera al stock, mostrar "Stock Insuficiente" y terminar el programa.*/

/*Console.Write("Ingrese el stock disponible inicial: ");
int stockDisponible = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad a retirar: ");
int cantidadSolicitada = int.Parse(Console.ReadLine());

while (cantidadSolicitada <= stockDisponible)
{
    stockDisponible -= cantidadSolicitada;
    Console.WriteLine($"Retiro exitoso. Nuevo stock disponible: {stockDisponible}");

    Console.Write("Ingrese la siguiente cantidad a retirar: ");
    cantidadSolicitada = int.Parse(Console.ReadLine());
}

Console.WriteLine("Stock Insuficiente.");*/

/*​5- Cargar las notas de los exámenes de los alumnos una por una dentro de un bucle while 
 * (ingresar una nota igual a -1 para finalizar). Si la nota es mayor o igual a 60, 
 * sumarlo al contador de "Aprobados". Si es menor a 60 pero mayor o igual a 0, 
 * sumarlo al contador de "Desaprobados". Al final, mostrar el total de alumnos en cada categoría.*/

/*int aprobados = 0;
int desaprobados = 0;

Console.Write("Ingrese la nota del alumno (-1 para terminar): ");
double nota = double.Parse(Console.ReadLine());

while (nota != -1)
{
    if (nota >= 60)
    {
        aprobados++;
    }
    else if (nota >= 0)
    {
        desaprobados++;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese una nota válida (mayor o igual a 0).");
    }

    Console.Write("Ingrese la nota del siguiente alumno (-1 para terminar): ");
    nota = double.Parse(Console.ReadLine());
}

int totalAlumnos = aprobados + desaprobados;

Console.WriteLine("--- Resumen de Exámenes ---");
Console.WriteLine($"Total de alumnos evaluados: {totalAlumnos}");
Console.WriteLine($"Aprobados: {aprobados}");
Console.WriteLine($"Desaprobados: {desaprobados}");*/

/*6- Crear un programa que procese compras de clientes en un bucle while hasta 
 * que se ingrese un total de compra igual a 0. Para cada compra, pedir el tipo de 
 * cliente (string: "VIP", "REGULAR" o "NUEVO"). Si es "VIP", aplicar un 20% de descuento.
 * Si es "REGULAR", aplicar un 10% de descuento. Si es "NUEVO", no realizar descuento. 
 * Mostrar en cada iteración el descuento aplicado y el precio final a pagar por ese cliente.*/


Console.Write("Ingrese el total de la compra (0 para terminar): ");
decimal totalCompra = decimal.Parse(Console.ReadLine());

while (totalCompra != 0)
{
    if (totalCompra > 0)
    {
        Console.Write("Ingrese el tipo de cliente (VIP, REGULAR, NUEVO): ");
        string tipoCliente = Console.ReadLine().ToUpper();

        decimal porcentajeDescuento = 0m;

        if (tipoCliente == "VIP")
        {
            porcentajeDescuento = 0.20m;
        }
        else if (tipoCliente == "REGULAR")
        {
            porcentajeDescuento = 0.10m;
        }
        else if (tipoCliente == "NUEVO")
        {
            porcentajeDescuento = 0m;
        }
        else
        {
            Console.WriteLine("Tipo de cliente no reconocido. Se procesará sin descuento.");
        }

        decimal descuentoAplicado = totalCompra * porcentajeDescuento;
        decimal precioFinal = totalCompra - descuentoAplicado;

        Console.WriteLine($"Descuento aplicado: ${descuentoAplicado:N2}");
        Console.WriteLine($"Precio final a pagar: ${precioFinal:N2}");
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un monto válido mayor a 0.");
    }

    Console.Write("Ingrese el total de la siguiente compra (0 para terminar): ");
    totalCompra = decimal.Parse(Console.ReadLine());
}

Console.WriteLine("Procesamiento de compras finalizado.");