/*int numero = 10;
while (numero >= 0)
{
    Console.WriteLine($"El número es: {numero}");
    numero--;
    //numero = numero - 1;
}
Console.WriteLine($"¡Fin del bucle! {numero}");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine($"El número es: {i}");

}


int promedio = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Ingrese la nota del alumno {i}");
    int nota  = int.Parse(Console.ReadLine());
    promedio += nota;
    //promedio = promedio + nota;
}
promedio = promedio / 5;
Console.WriteLine($"El promedio de las notas es: {promedio}");
*/

/*1- Definir un saldo inicial de 5000000. 
 * Permitir al usuario realizar retiros de 
 * dinero dentro de un bucle while siempre 
 * que el monto ingresado sea mayor a 0. 
 * El bucle debe terminar inmediatamente 
 * si el saldo llega a 0 o si el usuario 
 * ingresa un monto menor o igual a 0. 
 * En cada extracción, restar el monto y 
 * mostrar el saldo restante.*/

decimal saldo = 5000000;
while (saldo > 0)
{
    Console.WriteLine("Ingrese el monto a retirar");
    decimal retiro = decimal.Parse(Console.ReadLine());
    if (retiro <= saldo && retiro > 0)
    {
        saldo -= retiro;
        Console.WriteLine($"Saldo restante : ${saldo:N2}");
    }
    else if (retiro > saldo && saldo > 0)
    {
        Console.WriteLine("Fondos insuficientes");
    }
    else if (retiro <= 0)
    {
        Console.WriteLine("Monto inválido, el retiro debe ser mayor a 0");
        break;
    }
}
Console.WriteLine($"Saldo restante : ${saldo:N2}");