int altura = 100;
int countVip = 0;
int juego = 0;
while (altura > 0)
{
    Console.WriteLine("Ingrese la altura [0 para finalizar]");
    altura = int.Parse(Console.ReadLine());
    if (altura >= 120)
    {
        Console.WriteLine("Tiene pase vip?");
        Console.WriteLine("1. Si");
        Console.WriteLine("2. No");
        int vip = int.Parse(Console.ReadLine());
        if (altura >= 140)
        {
            juego++;
        }
        else if (altura >= 120 && altura < 140 && vip == 1)
        {
            countVip++;
            juego++;
        }
    }
}

Console.WriteLine($"Catidad de Jugadores: {juego}, cantidad de VIP:{countVip}");