
/*Console.WriteLine("Ingrese cuantas cucharadas de sopa tiene su plato");
int cucharadas = int.Parse(Console.ReadLine());

while (cucharadas > 0)
{
    Console.WriteLine("Ingrese cuantas cucharadas de sopa va a consumir");
    int consumir = int.Parse(Console.ReadLine());
    cucharadas = cucharadas - consumir;
    Console.WriteLine("Quedan " + cucharadas + " cucharadas de sopa en el plato");
}

Console.WriteLine("Ya no queda sopa en el plato");*/



/*1
 * Estás manejando un auto en la ruta y arrancás con un 
 * tanque de 60 litros de combustible. El viaje dura varias horas. 
 * En cada hora (que representa una vuelta del bucle while), 
 * el programa te debe pedir que ingreses cuántos 
 * litros consumiste en ese tramo.
Si el combustible restante cae por debajo de los 10 litros, 
debés mostrar un aviso: "¡ALERTA: Combustible en reserva!".
Si en alguna hora el consumo ingresado hace que el 
combustible sea menor o igual a 0, el viaje se termina 
inmediatamente mostrando: "Te quedaste varado en la ruta. Viaje interrumpido".
El bucle continúa mientras te quede combustible por encima de 0. 
Al finalizar de manera exitosa (si no te quedaste varado), 
debés mostrar cuántos litros te sobraron.*/

int tanque = 60;
bool seguir = true;
int vueltas = 0;
while (seguir)
{ 
    Console.WriteLine("Desea realizar otra vuelta? 1- si 2-no");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 1)
    { 
        vueltas = vueltas + 1;
        Console.WriteLine("Ingrese cuantos litros consumio en esta vuelta");
        int consumo = int.Parse(Console.ReadLine());    
        tanque = tanque - consumo;
        Console.WriteLine("Quedan " + tanque + " litros de combustible en el tanque");
        if (tanque < 10 && tanque > 0)
        { 
            Console.WriteLine("¡ALERTA: Combustible en reserva!");
        }
        else if (tanque <= 0)
        {
            Console.WriteLine("Te quedaste varado en la ruta. Viaje interrumpido");
             seguir = false;
        }

    }
    else
    {
        seguir = false;
    }
}

if(tanque > 0)
{
    Console.WriteLine("El viaje ha finalizado exitosamente, te sobraron " + tanque + " litros de combustible");
}   
Console.WriteLine("Diste " + vueltas + " vueltas");
