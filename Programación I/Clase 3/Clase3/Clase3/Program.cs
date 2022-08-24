/*
 * Escriba un algoritmo que permita ingresar un valor y guardarlo en una variable, 
 * la misma deberá llamarse <nombre>, dicho algoritmo deberá imprimir el siguiente 
 * mensaje: Este es un programa de <nombre>.

Escriba un algoritmo que permita ingresar un numero con decimales y guardarlo en una variable, 
luego el algoritmo debe permitir ingresar un segundo número entero y guardarlo en otra variable, 
en una tercer variable deberá guardar la suma de dichos valor e imprimirlo en pantalla 
con el siguiente mensaje: La suma de <variable1> y <variable2> da como resultado <variable3>.

Escriba un algoritmo que permita ingresar la edad de una persona, 
la edad de un hijo/a de esa persona y mediante un cálculo obtener 
que edad tenía la primera persona cuando nació su hijo/a.

Un vendedor recibe un sueldo base y un extra del 0.75% del 
sueldo por cada venta que realiza. Escriba un algoritmo que 
permita ingresar el sueldo y la cantidad de ventas, dicho algoritmo 
deberá imprimir en pantalla el importe a cobrar por el vendedor.
*/

/*EJERCICIO 1*/
//Console.WriteLine("Escriba un nombre");
//string nombre = Console.ReadLine();
//Console.WriteLine("Este es un programa de " + nombre);

/*EJERCICIO 2*/
/*(decimal)12.25 convertir números de un tipo a otro que este contenido ej short en int*/
/*Console.WriteLine("Ingrese un decimal");
decimal variable1;
string lectura1 = Console.ReadLine();
variable1 = decimal.Parse(lectura1);

Console.WriteLine("Ingrese un entero");
int variable2;
string lectura2 = Console.ReadLine();
variable2 = int.Parse(lectura2);

decimal variable3;
variable3 = variable1 + variable2;

Console.WriteLine($"La suma de {variable1} y {variable2} da como resultado {variable3}");*/
//Console.WriteLine("La suma de " + variable1 + " y " + variable2 + " da como resultado " + variable3);

//variable1 = //decimal.Parse() Console.ReadLine();

/*EJERCICIO 4*/
/*Console.WriteLine("Ingrese un sueldo");
string lectura = Console.ReadLine();
decimal sueldo = Convert.ToDecimal(lectura);
Console.WriteLine("Ingrese la cantidad de ventas");
string lectura2 = Console.ReadLine();
int ventas = Convert.ToInt32(lectura2);
decimal resultado = (sueldo * (decimal)0.75) / 100;
decimal totalVentas = resultado * ventas;
decimal total = totalVentas + sueldo;
Console.WriteLine("A cobrar: $" + total);*/


/*
decimal resultado;
resultado = (sueldo * (decimal)0.75) * ventas;

decimal com;
com = ventas * (decimal)0.75;
resultado = sueldo + com;

decimal resultado2;
resultado2 = sueldo * (decimal)1.75;
decimal com2 = 0;*/


/*EJERCICIO 3*/
Console.WriteLine("Ingrese su edad");
string lectura1 = Console.ReadLine();
int edad = Convert.ToInt32(lectura1);
Console.WriteLine("Ingrese la edad de su hijo/a");
string lectura2 = Console.ReadLine();
int edadHi = Convert.ToInt32(lectura2);
int resultado = edad - edadHi;
Console.WriteLine("la edad era: " + resultado);












