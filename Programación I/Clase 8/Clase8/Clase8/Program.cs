/*tablas();

void tablas()
{
    Console.Clear();
    p("Ingrese un número");
    int value = Convert.ToInt32(Console.ReadLine());
    p($"{value} X 0 = {multiplicar(value, 0)}");
    p($"{value} X 1 = {multiplicar(value, 1)}");
    p($"{value} X 2 = {multiplicar(value, 2)}");
    p($"{value} X 3 = {multiplicar(value, 3)}");
    p($"{value} X 4 = {multiplicar(value, 4)}");
    p($"{value} X 5 = {multiplicar(value, 5)}");
    p($"{value} X 6 = {multiplicar(value, 6)}");
    p($"{value} X 7 = {multiplicar(value, 7)}");
    p($"{value} X 8 = {multiplicar(value, 8)}");
    p($"{value} X 9 = {multiplicar(value, 9)}");
    menu();
}

void menu()
{
    p("Seguir resolviendo?");
    p("1- Si");
    p("2- No");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value == 1)
    {
        tablas();
    }
}

void tablasFor()
{
    Console.Clear();
    p("Ingrese un número");
    int value = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 10; i++)
    {
        p($"{value} X {i} = {value * i}");
    }
    p("Enter para continuar");
    Console.ReadLine();
    tablasFor();
}

decimal multiplicar(decimal a, decimal b)
{
    return a * b;
}

void p(string lectura)
{
    Console.WriteLine(lectura);
}*/



/*Ingresar alumnos para calcular un promedio general de la 
 * materia e ingresar notas por cada alumno para generar un 
 * promedio de cada alumno*/

int notasAlumnos = 0;
int sumaNotas = 0;
int cantidadAlumnos = 0;
int promedios = 0;

MenuAlumno();

void MenuAlumno()
{
    Print("Ingresar un alumno?");
    Print("1- Si");
    Print("2- No");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value == 1)
    {
        cantidadAlumnos++;
        IngresarNota();
    }
    else
    {
        Print($"Promedio total: {promedios / cantidadAlumnos}");
    }
}

void IngresarNota()
{
    Print("Ingresar nota?");
    Print("1- Si");
    Print("2- No");
    int value = Convert.ToInt32(Console.ReadLine());
    if (value == 1)
    {
        notasAlumnos++;
        Print("Ingrese el valor de la nota");
        sumaNotas = sumaNotas + Convert.ToInt32(Console.ReadLine());
        IngresarNota();
    }
    else
    {
        promedios = promedios + (sumaNotas / notasAlumnos);
        Print($"Promedio del alumno: {sumaNotas / notasAlumnos}");
        Print("Enter para continuar");
        Console.ReadLine();
        sumaNotas = 0;
        notasAlumnos = 0;
        MenuAlumno();
    }

}



void Print(string lectura)
{
    Console.WriteLine(lectura);
}
