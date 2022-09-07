bool respuesta = true;

int cantidad = 0;

primeraPregunta();



while (respuesta)
{



    primeraPregunta();
}






bool primeraPregunta()
{
    print("Ingresar un nueva venta?");
    print("1- si");
    print("2- no");
    var resultado = Console.ReadKey().KeyChar;
    //respuesta nueva venta
    if (resultado == (char)'1')
    {
        cantidad++;
        return true;
    }
    //respuesta cancelar venta
    else if (resultado == (char)'2')
    {
        return false;
    }
    //error en la respuesta
    else
    {
        Console.Clear();
        print("Opción incorrecta");
        primeraPregunta();
        return true;
        
    }
}



void print(string text)
{
    Console.WriteLine(text);
}


decimal porcentaje(decimal importe, decimal valor)
{ 
    return (importe * valor) / 100;

}


//ingresar importes de ventas, elegir el iva a calcular (21 / 10.5), acumular venta sin iva, acumular iva y mostrar por separado

/*
decimal suma(decimal a, decimal b)
{
    return a + b;
}*/


/*void primeraPregunta2()
{
    print("Ingresar un nueva venta?");
    print("1- si");
    print("2- no");
    var resultado = Console.ReadLine();
    
    if (resultado == "1")
    {
        print("1- si");
    }
    else if (resultado == "2")
    {
        print("2- no");
    }
    else
    {
        Console.Clear();
        print("Opción incorrecta");
        primeraPregunta2();
    }
}*/


