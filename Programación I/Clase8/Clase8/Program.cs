/*1- Un cine ofrece tarifas especiales:
Entrada general: $8000
Menores de 12 años: 50% de descuento
Adultos mayores (más de 65): 30% de descuento
Horarios antes de las 20.: tarifa estándar
Horarios después de 20.: tarifa adicional de $2000 (por servicio nocturno)
Solicitar la edad del cliente y la hora de la función para calcular.
Mostrar el monto total a pagar.
Mostrar el total recaudado.
Mostrar recaudación por servicio nocturno.

const double entrada = 8000;
bool continuar = true;
double total = 0, nocturno = 0;

while (continuar)
{
    Console.WriteLine("Ingresar una nueva venta? 1- Si  2- No");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 1)
    {
        Console.WriteLine("Ingrese la edad");
        int edad = int.Parse(Console.ReadLine());
        //Console.WriteLine("Ingrese horario de compra");
        int hora = DateTime.Now.Hour;
        double totalPagar = TotalPago(edad, hora);
        total += totalPagar;
        Console.WriteLine($"Valor de la entrada ${totalPagar.ToString("N2")}");
    }
    else
    {
        continuar = false;
    }


}

Console.WriteLine($"Importe total recaudad ${total.ToString("N2")}");
Console.WriteLine($"Total servicio nocturno ${nocturno.ToString("N2")}");

double TotalPago(int edad, int hora)
{
    double importe = entrada;
    if (edad < 12)
    {
        importe = entrada / 2.0;
    }
    else if (edad > 65)
    {
        importe = entrada * 0.7;
    }
    if (hora >= 20)
    {
        importe += 2000;
        nocturno += 2000;
    }
    return importe;
}*/

/*
2- Una fábrica produce juguetes con los siguientes costos:
Costo de materiales por unidad: $7300
Mano de obra fija: $500.000 por lote (200 productos).
La producción semanal oscila entre 1000 y 10000 unidades
Calcular:
El costo total semanal según cantidad producida 
(el costo de materiales por unidad * cantidad).
Si el costo total supera los $5.000.000, agregar un coste 
adicional fijo de $200.000
La ganancia se obtiene vendiendo cada unidad a un precio fijo.
Solicitar la cantidad producida y mostrar costo por unidad, 
solicitar un precio de venta por arriba del costo y calcular ganancia.*/
/*
const double costo = 7300, manoObra = 500000, extra = 200000, costoMax =5000000;
int productos = 0;



double CostoManoObra()
{
    double calculo = (double)productos / (double)200;
    double resto = productos % 200;
    if (resto != 0)
    {
        calculo++;
    }
    return calculo * manoObra;
}

Produccion();

double CostoProduccionTotal()
{
    double costoProduccion = costo * (double)productos;
    costoProduccion += CostoManoObra();
    if (costoProduccion > costoMax)
    {
        costoProduccion += extra;
    }
    return costoProduccion;
}



double precioProduto = CostoProduccionTotal() / (double)productos;
Console.WriteLine($"Costo por unidad ${precioProduto.ToString("N2")}");
double precioVenta = 0;
Venta();



void Venta() 
{
    Console.WriteLine($"Ingrese un precio de venta superior a {precioProduto.ToString("N2")}");
    precioVenta = double.Parse(Console.ReadLine());
    if (precioVenta <= precioProduto)
    {
        Venta();
    }
    else
    {
        double ganancia = precioVenta - precioProduto;
        ganancia = ganancia * productos;
        Console.WriteLine($"Gancia total ${ganancia.ToString("N2")}");
    }
}

void Produccion()
{
    Console.WriteLine("Ingrese la producción semanal");
    productos = int.Parse(Console.ReadLine());
    if (productos < 1000 || productos > 10000)
    {
        Console.WriteLine("Valor incorrecto");
        Produccion();
    }
}*/

/*
 3- Un colegio cobra una matrícula base que puede variar según el nivel.
Si la matrícula se realiza antes de una fecha límite, 
se obtiene un descuento del 15%.
Si se realiza en cuotas (3 cuotas o más), se suma un recargo 
del 5% por cuota adicional (sobre la cuota base).
Si el estudiante es hermano de un alumno activo, hay un descuento 
adicional del 10% en la matrícula total.
Solicitar los datos del estudiante a matricular.
Calcular el monto a pagar, mostrando descuentos, mostrar 
recargos y mostrar total final.
Al finalizar mostrar cantidad de alumnos matriculados e 
importe total recaudado
 
 */

/*
double matriculaBase = 0, totalRecaudado = 0, matricula = 0;
int alumnos = 0;
Console.WriteLine("Ingrese el importe de la matricula base");
matricula = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la fecha limite dd/mm/aaaa");
DateTime fecha = Convert.ToDateTime(Console.ReadLine());

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Ingresar un nuevo alumno? 1- Si  2- No");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 1)
    {

        Console.WriteLine("Ingrese fecha de inscripción");
        DateTime inscripcion = Convert.ToDateTime(Console.ReadLine());
        Nivel();
        double descuento = CalculoDescuento(inscripcion);
        double recargo = CalculoRecargo();
        Console.WriteLine($"Descuento: ${descuento.ToString("N2")}");
        Console.WriteLine($"Recargo: ${recargo.ToString("N2")}");
        double totalAPagar = matriculaBase;
        totalAPagar += recargo;
        totalAPagar -= descuento;
        Console.WriteLine($"Total: ${totalAPagar.ToString("N2")}");
        alumnos++;
        totalRecaudado += totalAPagar;
    }
    else
    {
        continuar = false;
        Console.WriteLine($"Cantidad de alumnos matriculados {alumnos}");
        Console.WriteLine($"Total recaudado ${totalRecaudado.ToString("N2")}");
    }
}


double CalculoRecargo()
{
    Console.WriteLine("Pago en 3 cuotas o más? 1- Si  2- No");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 2)
    {
        return 0;
    }
    else
    {
        Console.WriteLine("Ingrese la cantidad de cuotas hasta 12");
        int cuotas = int.Parse(Console.ReadLine());
        int interes = 5 * cuotas;
        return  (matriculaBase * interes) / 100;
    }
}

double CalculoDescuento(DateTime registro)
{
    double descuento = 0;
    Console.WriteLine("Tiene hermanos matriculados? 1- Si  2-No");
    if (int.Parse(Console.ReadLine()) == 1)
    {
        descuento += matriculaBase * 0.1;
    }
    if (registro <= fecha)
    {
        descuento += matriculaBase * 0.15;
    }

    return descuento;
}







void Nivel()
{
    Console.Clear();
    Console.WriteLine("Seleccione el nivel");
    Console.WriteLine("1- Inicial");
    Console.WriteLine("2- Primario");
    Console.WriteLine("3- Secundario");
    Console.WriteLine("4- Superior");
    int nivel = int.Parse(Console.ReadLine());
    switch (nivel)
    {
        case 1:
            matriculaBase = matricula;
            break;
        case 2:
            matriculaBase = matricula * 1.1;
            break;
        case 3:
            matriculaBase = matricula *1.15;
            break;
        case 4:
            matriculaBase = matricula * 1.2;
            break;
    }
}

*/

