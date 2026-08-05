
/*1. Leer dos notas n1 y n2. Calcular el promedio. Si el promedio es mayor o igual a 7, mostrar Aprobado, sino Reprobado.

2. Leer el precio de un producto. Si el precio es mayor a 5000, restarle 500 de descuento y mostrar el nuevo precio.

3. Leer un número x. Si x es un número positivo (mayor a 0), multiplicarlo por 2, sino multiplicarlo por 3. Mostrar el resultado.

4.  Leer la cantidad de productos y el precio del mismo. Calcular el total. Si el total supera los 10000, mostrar: supera presupuesto.

5. Leer la edad de una persona. Sumarle 10 años. Si el resultado es mayor a 18, mostrar: será mayor de edad.

6. Leer goles de local y goles de visitante. Restar los goles. Si el resultado es mayor a 0, mostrar: ganó el Local.

7. Leer un número de caramelos y un número de chicos. Si los caramelos son más que los chicos, mostrar: alcanza, sino faltan caramelos.

8. Leer el lado de un cuadrado. Calcular el perímetro (lado * 4). Si el perímetro es mayor a 100, mostrar: cuadrado grande, sino cuadrado chico.

9. Leer distancia y consumo. Si la distancia multiplicada por el consumo es mayor a 50, mostrar: cargar combustible.

10. Leer sueldo y gastos. Restar sueldo - gastos. Si el resultado es menor a 0, mostrar déficit, sino mostrar ahorro disponible.*/


/*int n1 = 0;
int n2 = 0;

Console.WriteLine("Ingrese la primer nota");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la segunda nota");
n2= int.Parse(Console.ReadLine());
int promedio = (n1 + n2) / 2;
if (promedio > 7) 
{
    Console.WriteLine("Aprobado, nota: " + promedio);
}
else
{
    Console.WriteLine($"Reprobado, nota: {promedio}");
}*/

/*decimal precio = 0;
Console.WriteLine("Ingrese el precio del producto");
precio = decimal.Parse(Console.ReadLine());
if (precio > 5000)
{
    precio -= 500;
    Console.WriteLine($"El nuevo precio con descuento es: {precio}");
}
else
{
    Console.WriteLine($"El precio del producto es: {precio}");
}*/

int x = 0;
if (x < 0)
{ 
    x = x * 2; 
}
else
{
    x = x * 3;
}
Console.WriteLine($"Valor de X = {x}");