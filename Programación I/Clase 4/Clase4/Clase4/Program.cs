string[] lista = new string[4];


Console.WriteLine("Ingrese una palabra");
string palabra1 = Console.ReadLine();
int pal1 = palabra1.Length;

Console.WriteLine("Ingrese una palabra");
string palabra2 = Console.ReadLine();
int pal2 = palabra2.Length;

Console.WriteLine("Ingrese una palabra");
string palabra3 = Console.ReadLine();
int pal3 = palabra3.Length;

/*if (pal1 > pal2)
{
    Console.WriteLine($"{palabra1} es mayor que {palabra2}");
}
else 
{
    Console.WriteLine($"{palabra2} es mayor que {palabra1}");
}*/

if (pal1 >= pal2 && pal1 >= pal3)
{
    if (pal2 <= pal3)
    {
        lista[0] = palabra2;
        lista[1] = palabra3;
        lista[2] = palabra1;
    }
    else
    {
        lista[0] = palabra3;
        lista[1] = palabra2;
        lista[2] = palabra1;
    }
}
else if (pal2 >= pal1 && pal2 >= pal3)
{
    if (pal1 <= pal3)
    {
        lista[0] = palabra1;
        lista[1] = palabra3;
        lista[2] = palabra2;
    }
    else
    {
        lista[0] = palabra3;
        lista[1] = palabra1;
        lista[2] = palabra2;
    }
}
else if (pal3 >= pal2 && pal3 >= pal1)
{
    if (pal2 <= pal3)
    {
        lista[0] = palabra2;
        lista[1] = palabra1;
        lista[2] = palabra3;
    }
    else
    {
        lista[0] = palabra1;
        lista[1] = palabra2;
        lista[2] = palabra3;
    }
}

Console.WriteLine($"Orden asc {lista[0]}, {lista[1]}, {lista[2]}");
Console.WriteLine($"Orden desc {lista[2]}, {lista[1]}, {lista[0]}");