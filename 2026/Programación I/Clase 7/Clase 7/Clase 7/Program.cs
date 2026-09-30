/*Un parque de diversiones controla el ingreso a su montaña 
 * rusa durante el turno mañana. Se registra el ingreso continuo 
 * de visitantes de a uno por vez. En cada caso, se solicita 
 * ingresar la altura en centímetros de la persona y si cuenta 
 * con un pase VIP (1 para Sí, 0 para No). Para ingresar al juego se 
 * exige una altura mínima de 140 cm; sin embargo, si la persona mide 
 * entre 120 cm y 139 cm pero posee un pase VIP, se le permite el 
 * acceso de manera excepcional. Si mide menos de 120 cm, el acceso 
 * es denegado sin importar el pase. El registro finaliza 
 * inmediatamente cuando se ingresa una altura de 0 cm. 
 * Al terminar el turno, el sistema debe mostrar la cantidad 
 * total de personas que pudieron subir al juego y cuántas de 
 * ellas accedieron gracias al beneficio del pase VIP. */


/*int altura = 0;
OtraAltura();
void Altura()
{
    Console.WriteLine("Ingrese la altura en cm");
    
    if (int.TryParse(Console.ReadLine(), out altura))
    {
        Console.WriteLine($"Su altura es de {altura}");
    }
    else
    {
        Console.WriteLine("Valor incorrecto para altura");
        Altura();
    }
}



void OtraAltura()
{

    try
    {
        Console.WriteLine("Ingrese la altura en cm");
        altura = int.Parse(Console.ReadLine());
        Console.WriteLine($"Su altura es de {altura}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Valor incorrecto para altura");
        OtraAltura();
    }
    
}*/


List<int> listaNumeros = new List<int>();

int numeros = 10;
while (numeros >= 0)
{

    Console.WriteLine("Ingrese el numero a guardar");
    numeros = ValidarNumero(Console.ReadLine());
    if (numeros > 0)
    {
        listaNumeros.Add(numeros);
    }
}


Console.WriteLine("Los nombre guardados son:");
foreach (int item in listaNumeros)
{
    Console.WriteLine($"{item}");
}



int ValidarNumero(string valor)
{
    int num = 0;
    if (!int.TryParse(valor, out num))
    {
        Console.WriteLine("Error en el valor ingresado");
    }
    return num;
}










/*Una fábrica de alimentos procesados evalúa la calidad de un lote cerrado de 15 frascos de mermelada en la línea de montaje. Para cada frasco se ingresa el código del tipo de producto (1: Frutilla, 2: Durazno, 3: Ciruela) y el peso neto detectado por la balanza en gramos. El peso estándar para cualquier sabor debe ser de 400 gramos. Si el frasco pesa entre 390 g y 410 g (inclusive), se considera dentro del margen "Aceptable". Si pesa menos de 390 g, se registra como "Bajo Peso". Si supera los 410 g, se considera "Sobrepeso". Adicionalmente, si el frasco es de "Frutilla" y presenta "Bajo Peso", la máquina aplica una marca automática para su descarte inmediato. Al procesar exactamente los 15 frascos, el programa debe imprimir la cantidad total de frascos en margen "Aceptable" y cuántos frascos del sabor Frutilla fueron marcados para descarte.*/

/*Un peaje interurbano cobra la tarifa de acceso a los vehículos que pasan por una cabina durante una guardia. Para cada vehículo se solicita ingresar la categoría mediante un número de opción (1: Auto $1.500, 2: Camión $3.000, 3: Ómnibus $2.500). Luego, se consulta el método de pago utilizado (1: Efectivo, 2: Telepase). Si el conductor abona con "Telepase", obtiene un 15% de descuento sobre la tarifa base de su categoría. Si paga en "Efectivo" y la categoría es "Camión", se le cobra un recargo fijo de $500 en concepto de tasa de mantenimiento vial. El cobro continuo de la cabina finaliza únicamente cuando se ingresa una categoría de vehículo igual a 0. Al cerrar la caja, el sistema debe calcular e informar el dinero total acumulado por la cabina y la cantidad de vehículos que pagaron utilizando Telepase.*/