const int animales = 50;


int g = 0;
int p = 0;
int ch = 0;
int ov = 0;
int cb = 0;
int ca = 0;
int v = 0;



for (int i = 0; i < animales; i++)
{
    Console.WriteLine("tiene pluma?");
    Console.WriteLine("1 --> Si");
    Console.WriteLine("0 --> No");
    if (Console.ReadLine() == "1")
    {
        Console.WriteLine("pico plano");
        Console.WriteLine("1 --> Si");
        Console.WriteLine("0 --> No");
        if (Console.ReadLine() == "1")
        {
            p++;
        }
        else
        {
            g++;
        }
    }
    else
    {
        Console.WriteLine("tiene pelo?");
        Console.WriteLine("1 --> Si");
        Console.WriteLine("0 --> No");
        if (Console.ReadLine() == "0")
        {
            ch++;
        }
        else
        {
            Console.WriteLine("es lana?");
            Console.WriteLine("1 --> Si");
            Console.WriteLine("0 --> No");
            if (Console.ReadLine() == "1")
            {
                ov++;
            }
            else 
            {
                Console.WriteLine("tipo de cola");
                Console.WriteLine("2 --> Corta");
                Console.WriteLine("1 --> Larga con pelo");
                Console.WriteLine("0 --> Larga sin pelo");
                string tipoCola = Console.ReadLine();
                if (tipoCola == "2")
                {
                    ca++;
                }
                else if(tipoCola == "1")
                {
                    cb++;
                }
                else
                {
                    v++;
                }
            }
        }
    }

    Console.Clear();
    Console.WriteLine($"g:{g}, p:{p}, ch:{ch}, ov:{ov}, ca:{ca}, cb:{cb}, v:{v}");


    /*Console.WriteLine("g:" + g + ", p:" + p);

    */
}





