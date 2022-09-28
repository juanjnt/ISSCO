using System.Threading;
/*
Console.WriteLine(DateTime.Now);




DateTime hoy = DateTime.Now;
string fecha = "2022/09/22";
hoy = Convert.ToDateTime(fecha);
Console.WriteLine(hoy);

DateTime manana =  new DateTime(2022, 09, 23);
Console.WriteLine(manana);

if (manana > hoy)
{
    Console.WriteLine("Fecha mayor mañana");
}

Console.WriteLine(manana.AddYears(1).AddMonths(6).AddDays(50));
Console.WriteLine(DateTime.Now.DayOfYear);
DateTime valor = new DateTime(2024, 12, 31, 22, 30, 0);
Console.WriteLine(valor.DayOfYear);
Console.WriteLine(valor.ToShortTimeString());
*/



Console.WriteLine("Iniciando aplicación...");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Cargando...");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Iniciando cronometro...");
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Iniciando cronometro... 3");
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Iniciando cronometro... 2");
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Iniciando cronometro... 1");
Thread.Sleep(1000);
Console.Clear();
int segundos = 0;
int minutos = 0;
/*while (true)
{
    segundos++;
    Thread.Sleep(1000);
    Console.Clear();
    if (segundos == 60)
    {
        segundos = 0;
        minutos++;
    }
    Console.WriteLine(minutos.ToString("D3") + ":" + segundos.ToString("D2"));
}*/

DateTime inicio = new DateTime(2000, 01, 01);
while (true)
{
    
    Thread.Sleep(1000);
    Console.Clear();
    inicio = inicio.AddSeconds(1);
    Console.WriteLine(inicio.ToString("HH:mm:ss"));
}
