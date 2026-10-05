using Actividad8.Ejercicio1;
using System.Text.Json.Serialization;

List<Alumno> listaAlumno = new List<Alumno>();
while (true)
{
    Console.Clear();
    Alumno alumno = new Alumno();
    
    alumno.Nombre = NombreAlumno();
    if (alumno.Nombre.ToUpper() == "FIN")
        break;
    alumno.Nota1 = NotaAlumno("Nota 1");
    alumno.Nota2 = NotaAlumno("Nota 2");
    listaAlumno.Add(alumno);
}
Resultados();

void Resultados()
{
    foreach (var item in listaAlumno)
    {
        double promedio = (item.Nota1 + item.Nota2) / 2;
        Console.WriteLine($"Alumno: {item.Nombre} - Promedio de Nota: {promedio:N2}");
    }

}

string NombreAlumno()
{
    string nombre = "";
    while (true)
    {
        Console.WriteLine("Ingrese el nombre del Alumno");
        nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("Valor incorrecto");
        }
        else
        {
            break;
        }
        
    }
    return nombre;
}

double NotaAlumno(string nota)
{
    double notaAlumno = 0;
    while (true)
    {
        Console.WriteLine($"Ingrese la {nota} del Alumno");
        if (!double.TryParse(Console.ReadLine(), out notaAlumno))
        {
            Console.WriteLine("Valor incorrecto");
        }
        else
        {
            break;
        }

    }
    return notaAlumno;
}