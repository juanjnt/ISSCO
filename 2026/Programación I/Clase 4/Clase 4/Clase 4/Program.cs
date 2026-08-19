
/*
    Console.WriteLine("Que es usted?");

    int valor = 0;
    valor = int.Parse(Console.ReadLine());

    switch (valor)
    {
        case 0:
            Console.WriteLine("Soy un cero");
            break;
        case 1:
            Console.WriteLine("Soy un uno");
            break;
        case 2:
            Console.WriteLine("Soy un dos");
            break;
        default:
            Console.WriteLine("No soy nada");
            break;
    }




    if (valor == 0)
    {
        Console.WriteLine("Soy un cero");
    }
    else if (valor == 1)
    {
        Console.WriteLine("Soy un uno");
    }
    else if (valor == 2)
    {
        Console.WriteLine("Soy un dos");
    }
    else
    {
        Console.WriteLine("No soy nada");
    }
*/

/*while (true)
{



    Console.WriteLine("Ingrese el tipo de vehículo [MOTO, AUTO, CAMIONETA]");
    string vehiculo = Console.ReadLine().ToUpper();
    double precio = 0;
    switch (vehiculo)
    {
        case "MOTO":
            precio = 800;
            break;
        case "AUTO":
            precio = 1500;
            break;
        case "CAMIONETA":
            precio = 2200;
            break;
        default:
            Console.WriteLine("Tipo de vehículo no reconocido");
            break;
    }
    if (precio > 0)
    {
        Console.WriteLine("Ingrese la cantidad de horas de estacionamiento");
        int horas = int.Parse(Console.ReadLine());

        double total = precio * (double)horas;
        Console.WriteLine($"Importe a pagar: {total:C2}");
    }
}*/

/*Una fábrica de electrodomésticos analiza la calidad de un lote 
 * cerrado de 10 productos antes de su distribución. 
 * Para cada uno de los 10 productos, el inspector ingresa la categoría del estado obtenido (estado):

"EXCELENTE": El producto pasa a venta premium.

"ACEPTABLE": El producto pasa a venta estándar.

"DEFECTUOSO": El producto pasa a reparación.

El sistema debe procesar exactamente los 10 productos, 
acumulando y mostrando al finalizar el reporte final con la cantidad 
total de productos clasificados en cada una de las 3 categorías. 
Si ingresa una categoría no válida, 
no se debe contar en ninguna y debe mostrar "Estado no reconocido".*/


/*int excelente = 0, aceptable = 0, defectuoso = 0, sinEstado = 0;
for (int i = 0; i < 10; i++)
{
    
    Console.WriteLine("Ingrese el estado del producto");
    Console.WriteLine("EXCELENTE / ACEPTABLE / DEFECTUOSO");
    string estado = Console.ReadLine().ToUpper();
    
    switch (estado)
    {
        case "EXCELENTE":
            excelente++;
            break;
        case "ACEPTABLE":
            aceptable++; 
            break;
        case "DEFECTUOSO":
            defectuoso++; 
            break;
        default:
            sinEstado++;
            Console.WriteLine("Estado no reconocido");
            break;
    }
    Console.WriteLine($"Analizando información del producto nº {i + 1}, su estado es: {estado}");
}

Console.WriteLine("======INFORME=======");
Console.WriteLine($"Excelente: {excelente} productos");
Console.WriteLine($"Aceptable: {aceptable} productos");
Console.WriteLine($"Defectuoso: {defectuoso} productos");*/

/*El encargado de un restaurante debe registrar en el sistema una tanda fija 
 * de 8 pedidos realizados durante el mediodía. Por cada pedido ingresado, 
 * se debe pedir el menú seleccionado (opcionMenu) y el precio base del plato (precio):

Opción 1 (Menú Ejecutivo): Aplica un descuento promocional del 15% sobre el precio.

Opción 2 (Menú Saludable): Se mantiene el precio base sin modificaciones.

Opción 3 (Menú Infantil): Aplica un descuento fijo de $1.000 sobre el precio.

El sistema debe procesar los 8 pedidos y, al finalizar la carga de la tanda completa, 
mostrar el monto total acumulado de facturación que recaudó el restaurante por la suma 
de todos los pedidos procesados.

*/

/*double total = 0;
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingrese la Opción de Menú");
    Console.WriteLine("Opción 1 - Menú Ejecutivo");
    Console.WriteLine("Opción 2 - Menú Saludable");
    Console.WriteLine("Opción 3 - Menú Infantil");
    int menu = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el precio del menú");
    double precio = double.Parse(Console.ReadLine());
    switch (menu)
    {
        case 1:
            //precio = precio - (precio / 0.15);
            precio -= precio * 0.15;
            break;
        case 3:
            precio -= 1000;
            break;
    }
    //total = total + precio;
    total += precio;
}
Console.WriteLine($"Total Facturado: {total:C2}");*/

/*En un curso se realiza la votación para elegir al delegado del aula. 
 * Se procesará la opinión de un total exacto de 15 alumnos habilitados 
 * para votar. Cada alumno ingresará el código de su opción elegida (voto):

Código 1: Voto para el Candidato A.

Código 2: Voto para el Candidato B.

Código 3: Voto en Blanco.

El sistema debe registrar los votos de los 15 estudiantes. Si un alumno 
ingresa cualquier otro número, el voto se debe registrar e incrementar en la 
categoría de "Votos Nulos". Al terminar la carga de los 15 alumnos, mostrar en 
pantalla el total de votos obtenidos por el Candidato A, el Candidato B, los 
Votos en Blanco y los Votos Nulos.*/

int candidatoA = 0, candidatoB = 0, nulos = 0, blancos = 0;

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Ingrese su voto alumnos Nº {i+1}");
    Console.WriteLine("1- Candidato A");
    Console.WriteLine("2- Candidato B");
    Console.WriteLine("3- Voto en Blanco");
    int voto = int.Parse(Console.ReadLine());
    switch (voto)
    {
        case 1:
            candidatoA++; break;
        case 2:
            candidatoB++; break;
        case 3:
            blancos++; break;
        default:
            nulos++; break;
    }
}

Console.WriteLine("=========RESULTADO DE LA VOTACIÓN==========");
Console.WriteLine($"Candidato A: {candidatoA} votos");
Console.WriteLine($"Candidato B: {candidatoB} votos");
Console.WriteLine($"Votos en Blanco: {blancos} votos");
Console.WriteLine($"Votos Nulos: {nulos} votos");