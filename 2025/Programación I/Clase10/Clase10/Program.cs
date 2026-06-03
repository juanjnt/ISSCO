/*List<(int nota, string nombre)> list = 
    new List<(int nota, string nombre)>();


string valor = "98dodlm";
if (string.IsNullOrWhiteSpace(valor))
{
    //mostrar error
}

int num;
if (!int.TryParse(valor, out num))
{
    //mostrar erro
}*/

/*1- Una estación meteorológica necesita analizar 
 * las variaciones del clima. Ingresa temperaturas 
 * hasta que ingrese un valor negativo.  
Determinar la temperatura máxima y mínima.
Contar cuántos días tuvieron temperaturas superiores a 30°C.
Mostrar el promedio de temperaturas.
*/

List<double> lstTemperaturas = new List<double>();

while (true)
{
    Console.WriteLine("Ingrese una temperatura");
    double temperatura = 0;
    if (!double.TryParse(Console.ReadLine(), out temperatura))
    {
        Console.WriteLine("Dato incorrecto");
    }
    else
    {
        if (temperatura < 0)
        {
            break;
        }
        lstTemperaturas.Add(temperatura);
    }
}
TemperaturaSuperior30();
MaximasMinimas();
Promedio();

void Promedio()
{
    double suma = 0;
    foreach (var item in lstTemperaturas)
    {
        suma += item;
    }
    double promedio = suma / lstTemperaturas.Count;
    Console.WriteLine($"Promedio de temperatura {promedio:N2}º");
}
void MaximasMinimas()
{
    double maxima = -100;
    double minima = 100;
    foreach (var item in lstTemperaturas)
    {
        if (item > maxima)
        {
            maxima = item;
        }
        if (item < minima)
        {
            minima = item;
        }
    }
    Console.WriteLine($"Temperatura mayor {maxima}º, temperatura menor {minima}º");
}
void TemperaturaSuperior30()
{
    int dias = 0;
    foreach (var item in lstTemperaturas)
    {
        if (item > 30)
        {
            dias++;
        }
    }
    Console.WriteLine($"Días con temperatura mayor a 30º: {dias}");
}
