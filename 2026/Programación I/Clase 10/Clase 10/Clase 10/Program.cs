using Clase_10;

List<ExpedienteVial> listaExpedientes = new List<ExpedienteVial>();



void MenuInicial()
{
    Console.Clear();    
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar expediente");
    Console.WriteLine("2. Mostrar expedientes");
    Console.WriteLine("3. Salir");
    int opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            AgregarExpediente();
            break;
        case 2:
            Resultados();
            break;
    }
}

MenuInicial();

void AgregarExpediente()
{
    var expediente = new ExpedienteVial();
    int nro = 0;
    while (true)
    {
        Console.WriteLine("Ingrese el número de expediente:");
        if (int.TryParse(Console.ReadLine(), out nro))
        {
            break;
        }
        else
        {
            Console.WriteLine("Número de expediente inválido. Intente nuevamente.");
        }
    }
    expediente.NumeroExpediente = nro;
    Console.WriteLine("Ingrese el dominio/patente:");
    expediente.DominioPatente = Console.ReadLine();
    Console.WriteLine("Ingrese el tipo de infracción:");
    expediente.TipoInfraccion = Console.ReadLine();
    Console.WriteLine("Ingrese el monto base:");
    expediente.MontoBase = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("¿Es reincidente? 1- Si / 2- No:");
    int esReincidente = Convert.ToInt32(Console.ReadLine());
    expediente.EsReincidente = esReincidente == 1;
    listaExpedientes.Add(expediente);
    Console.WriteLine("Expediente agregado correctamente. [Enter para continuar]");
    Console.ReadLine();
    MenuInicial();
}

void Resultados()
{
    int contarReincidentes = 0;
    double montoTotal = 0;
    Console.WriteLine("-----------------------------");
    Console.WriteLine("====Lista de Expedientes=====");
    Console.WriteLine("-----------------------------");
    foreach (var expediente in listaExpedientes)
    {
        if (expediente.TipoInfraccion.ToUpper() == "EXCESO DE VELOCIDAD" || expediente.TipoInfraccion.ToUpper() == "ALCOHOLEMIA")
            expediente.MontoBase = expediente.MontoBase * 1.25;
        if (expediente.EsReincidente)
            expediente.MontoBase += 15000;


        if (expediente.EsReincidente)
            contarReincidentes++;
        montoTotal += expediente.MontoBase;
        Console.WriteLine($"Número de expediente: {expediente.NumeroExpediente}");
        Console.WriteLine($"Dominio/Patente: {expediente.DominioPatente}");
        Console.WriteLine($"Tipo de infracción: {expediente.TipoInfraccion}");
        Console.WriteLine($"Monto base: {expediente.MontoBase:C2}");
        if (expediente.EsReincidente)
            Console.WriteLine($"Es reincidente: Sí");
        else
            Console.WriteLine($"Es reincidente: No");
        Console.WriteLine("-----------------------------");
    }
    Console.WriteLine("-----------------------------");
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"Total de reincidentes: {contarReincidentes}");
    Console.WriteLine($"Monto total recaudado: {montoTotal:C2}");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("-----------------------------");
    
    Console.WriteLine("[Enter para continuar]");
    Console.ReadLine();
    MenuInicial();
}