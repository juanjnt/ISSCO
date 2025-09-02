//EJERCICIO 1
//Leer un entero x. Si X es mayor que 10 dividirlos por 2.
/*
int x;

Console.WriteLine("Ingrese un número entero");
x = int.Parse(Console.ReadLine());
if (x > 10)
{
    x = x / 2;
}
Console.WriteLine("El valor de X es = " + x);
*/


// EJERCICIO 2
/*Leer un entero x. Si X es mayor que 10
/dividirlos por 2 sino sumar 100.*/
/*
int x = 0;
Console.WriteLine("Ingrese un número");
x = int.Parse(Console.ReadLine());
if (x > 10)
{
    x = x / 2;
}
else
{
    x = x + 100;
}

Console.WriteLine("Valor de X = " + x);*/

// EJERCICIO 3
/*Leer un entero x. Si X es menor igual que 
 * 300 sumarle 20, sino restarle 100.*/
/*
int x = 0;
Console.WriteLine("Ingrese un número");
x = int.Parse(Console.ReadLine());

if (x <= 300)
{
    x = x + 20;
}
else
{
    x = x - 100;
}

Console.WriteLine("Valor de X = " + x);
*/


/*Leer un entero x. Si al sumarle 50 a X 
 * el resultado es > 100 dividirlos por 2.*/





//ACTIVIDAD 6
/*Realice un algoritmo que permita ingresar 
 * números y sumarlos de manera indefinida, 
 * cuando se ingrese un número con valor 0 se 
 * deberá mostrar el valor acumulado en la suma.*/

/*
int numero = 1, suma = 0;

while (numero != 0)
{
    Console.WriteLine("Ingrese un número");
    numero = int.Parse(Console.ReadLine());
    suma += numero;
}

Console.WriteLine("valor de la suma: " + suma);
*/


/*Realice el algorito que permita 
 * calcular un promedio de 5 notas*/


/*
int promedio = 0;
int cantNotas = 0;

Console.WriteLine("Ingrese la cantidad de notas");
cantNotas = int.Parse(Console.ReadLine());

for (int i = 0; i < cantNotas; i++)
{
    Console.WriteLine($"Ingrese nota {i}");
    int notas = int.Parse(Console.ReadLine());
    promedio += notas;
}
promedio = promedio / cantNotas;
Console.WriteLine($"Promedio total: {promedio}");*/


//Leer un entero a. Si a está entre 50 y 100 (incluidos),
//restarle 25; en caso contrario, sumarle 30.

/*int a = 0;
Console.WriteLine("Ingrese un número");
a = int.Parse(Console.ReadLine());


if (a >= 50 && a <= 100)
{
    a = a - 25;
}
else
{
    a = a + 30;
}
Console.WriteLine("Valor de a: " + a);*/

