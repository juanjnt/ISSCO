
string lectura = "0";
/*int lg = lectura.Length;
int value = Convert.ToInt32(lectura);
switch (value)
{
    case < 10:
        Console.WriteLine("1 cifra");
        break;
    case  < 100:
        Console.WriteLine("2 cifras");
        break;
    case < 1000:
        Console.WriteLine("3 cifras");
        break;
    case < 10000:
        Console.WriteLine("4 cifras");
        break;
    case < 100000:
        Console.WriteLine("5 cifras");
        break;
    case < 1000000:
        Console.WriteLine("6 cifras");
        break;
    case < 10000000:
        Console.WriteLine("7 cifras");
        break;
    default:
        break;
}*/
int value = 0;

ingresarNumero();

void ingresarNumero()
{
    Console.Clear();
    Console.WriteLine("Ingrese un número");
    lectura = Console.ReadLine();
    value = Convert.ToInt32(lectura);
    Cifras();
    ParImpar();
    ResultadoPrimo();
    Console.WriteLine("");
    Console.WriteLine("Enter para continuar");
    Console.ReadLine();
    ingresarNumero();
}

void ParImpar()
{
    int otro = 0;
    if (value < 0)
    {
        otro = value * -1;
    }
    if ((otro % 2) > 0)
    {
        Console.WriteLine("Impar");
    }
    else
    {
        Console.WriteLine("Par");
    }
}
void Cifras()
{
    int result = value.ToString().Replace("-", "").Length;
    Console.WriteLine(result + " cifras");

}

void ResultadoPrimo()
{
    if (Primo())
    {
        Console.WriteLine("Es primo");
    }
    else
    {
        Console.WriteLine("No es primo");
    }
}

bool Primo()
{
    for (int i = 2; i < value; i++)
    {
        if (value % i == 0)
        {
            return false;
        }
    }
    return true;
}

/*
int v = 95;
bool esprimo = true;



for (int i = 2; i < v; i++)
{
    int resultado = v % i;
    if (resultado == 0)
    {
        esprimo = false;
    }
}

if (esprimo)
{
    Console.WriteLine("Es primo");
}*/



