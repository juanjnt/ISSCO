
using Actividad8.Ejercicio4;

List<Vehiculo> listaVehiculo = new List<Vehiculo>();

while (true)
{
    double precio = 800;
    var vehiculo = new Vehiculo();
    vehiculo.Tipo = MenuTipo();
    if (vehiculo.Tipo == "FIN")
    {
        break;
    }
    vehiculo.Patente = PatenteControl();
    vehiculo.HorasEstacionado = HorasEstacionamiento();
    listaVehiculo.Add(vehiculo);
}

foreach (var item in listaVehiculo)
{
    double precio = 800;
    if (item.Tipo == "Automóvil")
    {
        precio = 1500;
    }
    double importe = precio * (double)item.HorasEstacionado;
    Console.WriteLine($"[{item.Tipo}] - [{item.Patente}] -> ${importe:N2}");
}



int HorasEstacionamiento()
{
    Console.Clear();
    while (true)
    {
        Console.WriteLine("Ingrese la horas de estacionamiento");
        int horas = 0;
        if (int.TryParse(Console.ReadLine(), out horas) && horas >= 1)
        {
            return horas;
        }
        else
        {
            Console.WriteLine("Ingrese un valor correcto para horas");
        }
    }

}

string MenuTipo()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Seleccione el tipo de vehículo");
        Console.WriteLine("1. Automóvil");
        Console.WriteLine("2. Motocicleta");
        Console.WriteLine("3. Finalizar");
        int tipo = 0;
        if (int.TryParse(Console.ReadLine(), out tipo) && (tipo == 1 || tipo == 2 || tipo == 3))
        {
            switch (tipo)
            {
                case 1:
                    return "Automóvil";
                case 2:
                    return "Motocicleta";
                case 3:
                    return "FIN";
            }
        }

    }
}


string PatenteControl()
{
    Console.Clear();
    
    string patente = "";
    while (true)
    {
        bool registro = false;
        Console.WriteLine("Ingrese la patente del vehículo");
        patente = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(patente))
        {
            foreach (var item in listaVehiculo)
            {
                if (patente == item.Patente)
                {
                    Console.WriteLine("La patente ya se encuentra registrada");
                    registro = true;
                }
            }
            //if (registro == false)
            if (!registro)
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Ingrese una patente correcta");
        }
    }
    return patente;
}
