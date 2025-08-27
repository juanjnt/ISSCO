/*
MostrarMenu();
void MostrarMenu()
{
    Print(Mayuscula("Seleccione una opción:"));
    Print(Mayuscula("1. Sumar dos números"));

    Print(CalcularIva(10000, 21).ToString());
    Print(CalcularIva(10000, 10.5).ToString());
}
string Mayuscula(string valor)
{
    return valor.ToUpper();
}
double CalcularIva(double valor, double porcentaje)
{
    return valor * (porcentaje / 100);
}

void Print(string text)
{
    Console.WriteLine(text);
}*/


/*Una empresa de logística necesita llevar un seguimiento de 
 * entregas de mercadería y distancias recorridas, por día 
 * cada viajante se encarga de realizar 12 envíos, debe 
 * responder por cada envío si dicha entrega fue recibida. 
 * Realice un algoritmo que le permita al usuario ingresar 
 * la distancia en kilómetros desde un punto de entrega al 
 * siguiente y responder si el producto fue entregado, 
 * se deberá mostrar la cantidad de kilómetros recorridos y 
 * cuantos productos fueron recibidos.*/

/*
const int envios = 4;
double totalDistancia = 0;
int entregas = 0;

for (int i = 0; i < envios; i++)
{
    totalDistancia += Recorrido();
    Entregas();
}
Console.Clear();
Console.WriteLine($"Total de kilómetros recorridos: {totalDistancia}");
Console.WriteLine($"Total de productos entregados: {entregas}");

double Recorrido()
{
    Console.Clear();
    Console.WriteLine("Ingrese la distancia en kilómetros " +
        "desde un punto de entrega al siguiente:");
    double distancia = Convert.ToDouble(Console.ReadLine());
    return distancia;
}
void Entregas()
{
    Console.Clear();
    Console.WriteLine("¿El producto fue entregado? 1- Si  // 2- No");
    int respuesta = Convert.ToInt32(Console.ReadLine());
    if (respuesta == 1)
        entregas++;
}*/

/*La cajera de un resto/bar lleva el control de los pedidos y 
 * cuenta de los mozos, por noche, cada mozo entrega las diferentes 
 * cuentas que va cobrando, al finalizar el día la empresa les da 
 * un adicional del 5% recaudado a cada mozo aparte del pago diario. 
 * Realice un algoritmo que permita ingresar el importe del pago 
 * diario por mozo y la cantidad de mozos a contabilizar, por cada 
 * mozo se deberá ingresar el total recaudado, luego deberá 
 * calcular el 5% e indicar cuanto deberá cobrar el mozo con 
 * el pago diario incluido, al finalizar es necesario informar 
 * el total recaudado por todos los mozos.*/

double recaudacionTotal = 0;

Console.WriteLine("Ingrese el pago diario por mozo:");
double pagoDiario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de mozos a contabilizar:");
int cantidadMozos = Convert.ToInt32(Console.ReadLine());



for (int i = 0; i < cantidadMozos; i++)
{
    Console.WriteLine("Ingrese el importe de la cuenta");
    double importeCuenta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Pago diario: {pagoDiario.ToString("N2")}");
    double importeAdicional = CalculoAdicional(importeCuenta);
    Console.WriteLine($"Adicional:{importeAdicional.ToString("N2")}");
    Console.WriteLine($"Total a cobrar: {(pagoDiario + importeAdicional).ToString("N2")}");
}
Console.WriteLine($"Total recaudado por todos los mozos: {recaudacionTotal.ToString("N2")}");


double CalculoAdicional(double importe)
{
    recaudacionTotal += importe;
    return importe * 0.05;
}