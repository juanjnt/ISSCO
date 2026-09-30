/*Ejercicio 1
Descripción: Crear un programa que permita ingresar las notas finales (números enteros del 1 al 10) 
de un grupo de alumnos y las guarde en una lista. Una vez finalizada la carga, debe mostrar la nota más alta, 
el promedio del curso y cuántos alumnos aprobaron (nota mayor o igual a 6).

Lo que se debe validar:

Validar con int.TryParse que la entrada sea un número entero.

Usar if/else para comprobar que la nota esté dentro del rango permitido (entre 1 y 10 inclusive). 
Si no cumple, mostrar un mensaje de error y volver a pedirla.*/




List<int> listaNotas = new List<int>();
bool value = true;
while (value)
{
    Console.WriteLine("Desea ingresar una nota? 1- Si / 2- No");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 1)
    {
        CargarNota();
    }
    else
    {
        value = false;
        MostrarResultados();
    }

}

void MostrarResultados()
{
    int max = 0;
    int aprobados = 0;
    int promedio = 0;

    foreach (int item in listaNotas)
    { 
        if (item >= 6)
            aprobados++;
        promedio += item;
        if (item > max)
        {
            max = item;
        }
    }
    promedio = promedio / listaNotas.Count;

    Console.WriteLine($"Cantidad de Alumnos aprobados: {aprobados}");
    Console.WriteLine($"Promedios de notas: {promedio}");
    Console.WriteLine($"Nota más alta: {max}");

}


void CargarNota()
{
    Console.Clear();
    Console.WriteLine("Ingrese la nota del alumno");
    int nota = 0;
    if (!int.TryParse(Console.ReadLine(), out nota))
    {
        Console.WriteLine("Error en el valor ingresado [Enter para continuar]");
        Console.ReadLine();
        CargarNota();
    }
    else
    {
        if (nota >= 1 && nota <= 10)
        {
            listaNotas.Add(nota);
        }
        else
        {
            Console.WriteLine("Error en el valor ingresado [Enter para continuar]");
            Console.ReadLine();
            CargarNota();
        }
    }
}

