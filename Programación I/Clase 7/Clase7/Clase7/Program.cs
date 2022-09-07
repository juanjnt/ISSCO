p("Ingrese un número");
decimal value1 = Convert.ToDecimal(Console.ReadLine());
calculo();


void calculo()
{
    menu();
    int lectura = int.Parse(Console.ReadLine());
    p("Ingrese un número");
    decimal value2 = Convert.ToDecimal(Console.ReadLine());
    switch (lectura)
    {
        case 1:
            value1 = value1 + value2;
            break;
        case 2:
            value1 = value1 - value2;
            break;
        case 3:
            value1 = value1 * value2;
            break;
        case 4:
            value1 = value1 / value2;
            break;
    }
    
    Console.Clear();
    p("Resultado: " + value1);
    calculo();
}

void menu()
{
    
    p("1- Suma");
    p("2- Resta");
    p("3- Multiplicación");
    p("4- División");
    p("5- Fin");
}

void p(string value)
{ 
    Console.WriteLine(value);
}
