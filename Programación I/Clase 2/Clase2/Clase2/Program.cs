//Ejercicio 1
/*Console.WriteLine("Ingrese un nombre");
string nombre = Console.ReadLine();
string resultado = "Este es un programa de " + nombre;
Console.WriteLine(resultado);*/


Console.WriteLine("Ingrese un número decimal");
string lectura1 = Console.ReadLine();
decimal variable1; //= Convert.ToDecimal(lectura1);

bool resultad = decimal.TryParse(lectura1, out variable1);
if (!resultad)
{
    Console.WriteLine("El valor no es correcto, se utilizara 0");
}
//decimal.Parse(lectura1);
Console.WriteLine("Ingrese un número entero" );
int variable2 = Convert.ToInt32(Console.ReadLine());
decimal variable3 = variable1 + variable2;

Console.WriteLine($"La suma de {variable1}  y {variable2} da como resultado {variable3}");





