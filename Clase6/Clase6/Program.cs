/*Una clínica atiende diferentes tipos de consultas: 
 *general, especialista y emergencia. La tarifa por consulta es:
General: $2000
Especialista: $4000
Emergencia: $6000
La clínica realiza un registro diario de las personas atendidas. 
Para cada paciente, se ingresa el tipo de consulta.
El programa debe calcular y mostrar:
El total recaudado en el día.
La cantidad total de pacientes atendidos por cada tipo de consulta.
La cantidad total de pacientes atendidos en ese día.*/
/*
const double general = 2000, especialista = 4000, emergencia = 6000;
double total = 0;
int totalGeneral = 0, totalEmergencia = 0, totalEspecialista = 0, totalPacientes = 0;
bool consulta = true;
while (consulta)
{
    Console.WriteLine("Desea ingresar un nuevo paciente? 1- Si   2- No");
    string rsp = Console.ReadLine();
    if (rsp == "1")
    {
        Console.Clear();
        Console.WriteLine("Seleccione el tipo de consulta");
        Console.WriteLine("1- General");
        Console.WriteLine("2- Especialista");
        Console.WriteLine("3- Emergencia");
        string respuesta = Console.ReadLine();
        switch (respuesta)
        {
            case "1":
                total += general;
                totalGeneral++;
                break;
            case "2":
                total += especialista;
                totalEspecialista++;
                break;
            case "3":
                total += emergencia;
                totalEmergencia++;
                break;
        }
    }
    else
    {
        consulta = false;
    }

}

totalPacientes = totalEmergencia + totalEspecialista + totalGeneral;
Console.Clear();
Console.WriteLine($"Total recaudad: ${total:N2}");
Console.WriteLine($"Total Pacientes: {totalPacientes}");
Console.WriteLine($"Total Pacientes General: {totalGeneral}");
Console.WriteLine($"Total Pacientes Especialista: {totalEspecialista}");
Console.WriteLine($"Total Pacientes Emergencia: {totalEmergencia}");

*/













/*Una obra de construcción cuenta con varios albañiles. 
 * Cada albañil cobra un salario base de $300000, y además 
 * recibe un extra de $50000 por cada metro cuadrado que construya. 
 * La cantidad de metros cuadrados que construye cada albañil varía.
Realiza un programa que:
Permita ingresar el número total de albañiles.
Para cada albañil, ingrese la cantidad de metros cuadrados construidos.
Calcule y muestre:
El pago total de cada albañil (salario base + extras).
El monto total a pagar por la obra en conjunto.
La cantidad total de metros construidos por todos los albañiles.*/
/*
const double salario = 300000, extra = 50000;
double metrosTotal = 0, sueldoTotal = 0;

Console.WriteLine("Ingrese la cantidad de albañiles");
int empleado = int.Parse(Console.ReadLine());
for (int i = 0; i < empleado; i++)
{
    Console.WriteLine("Ingrese la cantidad de metros construidos");
    double metrosConstruidos = double.Parse(Console.ReadLine());
    double pago = metrosConstruidos * extra;
    pago += salario;
    sueldoTotal += pago;
    metrosTotal += metrosConstruidos;
    Console.WriteLine($"Total a cobrar: ${pago:N2}");


}
Console.WriteLine($"Total metros construidos: {metrosTotal}");
Console.WriteLine($"Total de obra: ${sueldoTotal:N2}");*/
