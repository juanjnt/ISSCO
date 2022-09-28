//EJERCICIO 1

/*Print("Ingrese el importe a invertir");
decimal importe = Convert.ToDecimal(Console.ReadLine());
Print("Ingrese la cantidad de días");
int dias = Convert.ToInt32(Console.ReadLine());

decimal valor = (decimal)69.5 / 365;
decimal interes = valor * dias;
decimal resultado = (importe * interes) / 100;
Print($"Su ganancia es de {resultado.ToString("C2")}");*/

//EJERCICIO 2
/*
Print("Ingrese el valor del dolar");
decimal dolar = Convert.ToDecimal(Console.ReadLine());
Cambio();



void Cambio()
{
    Console.Clear();
    Print("Ingrese la cantidad de U$D dolares a convertir ");
    decimal importe = Convert.ToDecimal(Console.ReadLine());
    Print($"El valor en Pesos de U$D {importe.ToString("N2")} es {(dolar * importe).ToString("C2")}");
    Print("ENTER para continuar");
    Console.ReadLine();
    Cambio();
}

*/

//EJERCICIO 3

/*
Print("Ingrese la cantidad de cm del lado del cuadrado");
decimal lado = Convert.ToDecimal(Console.ReadLine());
Print($"El area correspondiente al cuadrado es de {lado * lado} cm²");*/

//EJERCICIO 4
/*
decimal prueba = (decimal)14.5;
decimal tiempo1 = (decimal)23;
decimal tiempo2 = (decimal)19;
decimal tiempo3 = (decimal)22;
decimal distancia = (decimal)83;

decimal velocidad1 = (prueba / tiempo1) * 60;
decimal velocidad2 = (prueba / tiempo2) * 60;
decimal velocidad3 = (prueba / tiempo3) * 60;


Print("Velocidad de la primer prueba " + velocidad1.ToString("N2") + "km/h");
Print("Velocidad de la segunda prueba " + velocidad2.ToString("N2") + "km/h");
Print("Velocidad de la tercer prueba " + velocidad3.ToString("N2") + "km/h");

decimal promedio = (velocidad1 + velocidad2 + velocidad3) / 3;

Print("Velocidad promedio de las pruebas " + promedio.ToString("N2") + "km/h");

int resultado = (int)(distancia / promedio) * 60;


Print("En el circuito final demoraria " + resultado + " minutos");
*/


//EJERCICIO 6 
/*
Print("Ingrese la distancia de las pruebas en km");
decimal prueba = Convert.ToDecimal(Console.ReadLine());
Print("Ingrese el tiempo del primer dia de pruebas en minutos");
decimal tiempo1 = Convert.ToDecimal(Console.ReadLine());
Print("Ingrese el tiempo del segundo dia de pruebas en minutos");
decimal tiempo2 = Convert.ToDecimal(Console.ReadLine());
Print("Ingrese el tiempo del tercer dia de pruebas en minutos");
decimal tiempo3 = Convert.ToDecimal(Console.ReadLine());
Print("Ingrese la distancia del circuito final en km");
decimal distancia = Convert.ToDecimal(Console.ReadLine());

decimal velocidad1 = (prueba / tiempo1) * 60;
decimal velocidad2 = (prueba / tiempo2) * 60;
decimal velocidad3 = (prueba / tiempo3) * 60;


Print("Velocidad de la primer prueba " + velocidad1.ToString("N2") + "km/h");
Print("Velocidad de la segunda prueba " + velocidad2.ToString("N2") + "km/h");
Print("Velocidad de la tercer prueba " + velocidad3.ToString("N2") + "km/h");

decimal promedio = (velocidad1 + velocidad2 + velocidad3) / 3;

Print("Velocidad promedio de las pruebas " + promedio.ToString("N2") + "km/h");

int resultado = (int)(distancia / promedio) * 60;


Print("En el circuito final demoraria " + resultado + " minutos");

*/


DateTime salida = new DateTime(2000,01,01);

Print("Ingrese la hora de salida");
int hora = Convert.ToInt32(Console.ReadLine());
salida = salida.AddHours(hora);

Print("Ingrese la distancia en km");
int distancia = Convert.ToInt32(Console.ReadLine());

Print("Ingrese la velocidad promedio en km/h");
decimal velocidad = Convert.ToDecimal(Console.ReadLine());

decimal resultado = (distancia / velocidad) * 60;
Print("Tiempo para emplear el recorrido " + Convert.ToInt32(resultado) + " minutos");
salida = salida.AddMinutes(Convert.ToInt32(resultado));
Print("Llegada " + salida.ToShortTimeString() + "hs");
/*
if (resultado < 60)
{
    Print($"Llegada {hora}:{Convert.ToInt32(resultado)}hs");
}
else
{
    int horas = Convert.ToInt32(resultado / 60);
    hora = hora + horas;
    int min = Convert.ToInt32(resultado - (horas * 60));

    Print($"Llegada {hora}:{min}hs");
}*/





void Print(string txt)
{
    Console.WriteLine(txt);
}