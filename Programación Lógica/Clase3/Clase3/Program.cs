/*Una empresa de electrónica quiere llevar 
 * el inventario de sus productos. Desarrolla  
 * un algoritmo que permita al usuario ingresar 
 * la cantidad de productos a analizar, por 
 * cada producto se deberá solicitar el nombre 
 * y la cantidad de productos. Mostrar la cantidad 
 * de productos en total que tiene la tienda.*/

/*int totalProductos = 0, tipoProducto = 0;
Console.WriteLine("Ingrese cantidad de productos para analizar");
tipoProducto = int.Parse(Console.ReadLine());


for (int i = 0; i < tipoProducto; i++)
{
    Console.Clear();
    Console.WriteLine("Ingrese el nombre del producto");
    string nombre = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Ingrese la cantidade de {nombre}");
    totalProductos += int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine($"Total de productos: {totalProductos}");
*/


/*Una estación meteorológica toma las 
 * temperaturas diarias durante una 
 * semana. Desarrolla un algoritmo que 
 * permita al usuario ingresar las 
 * temperaturas de los 7 días (máxima y mínima) 
 * y mostrar el promedio de temperatura semanal.*/
/*
double total = 0;
for (int i = 1; i <= 7; i++)
{
    Console.Clear();
    Console.WriteLine($"Ingrese la minima del día {i}");
    double minima = double.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese la maxima del dia {i}");
    double maxima = double.Parse(Console.ReadLine());
    Console.Clear();
    double promedio = (maxima + minima) / 2.0;
    Console.WriteLine($"Promedio del día {i}: {promedio.ToString("N2")}");
    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    total += minima;
    total += maxima;
}
Console.Clear();
double promedioTotal = total / 14.0;
Console.WriteLine($"Promedio de temperatura semanal: {promedioTotal.ToString("N2")}");*/


/*En un curso, el profesor necesita ingresar las notas de 
 * x cantidad de estudiantes en una materia. 
Desarrolla un algoritmo que permita al usuario 
ingresar la cantidad de alumnos y cargar tres notas 
de cada estudiante. Mostrar el promedio por alumno y el 
promedio general de todos los alumnos.*/


/*
int alumnos = 0;
int promedioTotal = 0;
Console.WriteLine("Ingrese la cantidad de alumnos");
alumnos = int.Parse(Console.ReadLine());

for (int i = 0; i < alumnos; i++)
{
    int notas = 1, promedio = 0, cantNotas = 0, sumaNotas = 0;
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"Ingrese la nota {j}");
        notas = int.Parse(Console.ReadLine());
        sumaNotas += notas;
    }
    promedio = sumaNotas / cantNotas;
    Console.WriteLine($"Promedio del alumno {i + 1}: {promedio}");
    promedioTotal += promedio;
    while (notas > 0)
    {
        Console.WriteLine($"Ingrese la nota {cantNotas+1}");
        notas = int.Parse(Console.ReadLine());
        if (notas > 0)
        {
            cantNotas++;
            sumaNotas += notas;
        }
    }
    promedio = sumaNotas / cantNotas;
    Console.WriteLine($"Promedio del alumno {i + 1}: {promedio}");
    promedioTotal += promedio;
}
promedioTotal = promedioTotal / alumnos;
Console.WriteLine($"Promedio de los {alumnos} alumnos: {promedioTotal}");*/

/*En una empresa quieren evaluar la satisfacción de sus empleados. 
Desarrolla un algoritmo que solicite a 10 empleados que califiquen 
su satisfacción laboral de 1 a 5. Mostrar el promedio de satisfacción 
final.*/
/*int suma = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese su nivel de satisfacción de 1 a 5");
    int valor = int.Parse(Console.ReadLine());
    suma += valor;
}
double promedio = (double)suma / 3.0;
Console.WriteLine($"Promedio de satisfacción: {promedio:N2} ");*/


