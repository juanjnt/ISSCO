/*Un sistema de transporte público urbano gestiona el cobro del boleto según el perfil del pasajero. 
 * Al subir al colectivo, se debe ingresar el tipo de usuario (1: General, 2: Estudiantil, 3: Jubilado). E
 * l costo del boleto general es de $900. Si el usuario es Estudiantil, abona el 50% del valor general. 
 * Si es Jubilado, viaja sin costo (0%). El sistema debe mostrar el monto a cobrar en la pantalla del chofer.*/

/*MenuPrincipal();

void MenuPrincipal()
{
    Console.WriteLine("Seleccione el tipo de usuario");
    Console.WriteLine("1- General");
    Console.WriteLine("2- Estudiatil");
    Console.WriteLine("3- Jubilado");

    int respuesta = int.Parse(Console.ReadLine());
    CalculoBoleto(respuesta);
}

void CalculoBoleto(int respuesta)
{
    double boleto = 0;
    switch (respuesta)
    {
        case 1:
            boleto = (double)900;
            break;
        case 2:
            boleto = (double)900 / (double)2;
            break;
        case 3:
            boleto = 0;
            break;
    }
    Console.WriteLine($"Importe a cobrar: {boleto:C2} [Enter para continuar]");
    Console.ReadLine();
    Console.Clear();
    MenuPrincipal();
}
*/


/*Una escuela técnica analiza la asistencia diaria de sus 30 divisiones 
 * durante la jornada escolar. Para cada curso se ingresa el total de 
 * alumnos matriculados y la cantidad de alumnos presentes. El programa 
 * debe calcular el porcentaje de asistencia de cada aula y mostrarlo. 
 * Al finalizar el procesamiento de todas las divisiones, debe informar 
 * la cantidad total de estudiantes presentes en toda la escuela.*/

/*int alumnosTotal = 0;
int ausenteTotal = 0;

for (int i = 0; i < 30; i++)
{
    Console.WriteLine($"Ingrese la cantidad de alumnos matriculados en el Curso {i+1}");
    int matriculados = int.Parse(Console.ReadLine());
    Console.WriteLine($"Ingrese la cantidad de alumnos ausentes en el Curso {i + 1}");
    int ausentes = int.Parse(Console.ReadLine());
    alumnosTotal += matriculados;
    ausenteTotal += ausentes;
    double porcentaje = (double)ausentes * (double)100 / (double)matriculados;
    Console.WriteLine($"Porcentaje de alumnos ausentes en el Curso {i + 1}: {porcentaje:N2}%");
}

Console.WriteLine($"Cantidad de Alumnos Presentas en total: {alumnosTotal - ausenteTotal}");*/

/*Un inspector municipal realiza controles de velocidad en la avenida 
 * principal de la ciudad, donde el límite máximo permitido es de 60 km/h. 
 * Para cada vehículo controlado se ingresa la velocidad registrada. 
 * Si la velocidad es menor o igual a 60 km/h, no se genera sanción. 
 * Si supera los 60 km/h y llega hasta 80 km/h, se aplica una multa fija de $15.000. 
 * Si supera los 80 km/h, la multa asciende a $35.000. 
 * El control finaliza cuando se ingresa una velocidad igual a 0, 
 * mostrando al terminar la suma total de dinero acumulado en multas.*/

int velocidad = 0;
double multa = 0;
double acumulado = 0;

void PedirVelocidad()
{
    Console.WriteLine("Ingrese la velocidad del vehículo");
    velocidad = int.Parse(Console.ReadLine());
}

PedirVelocidad();
while (velocidad != 0)
{
    if (velocidad > 60 && velocidad <= 80)
    {
        multa = 15000;
    }
    else if (velocidad > 80)
    {
        multa = 35000;
    }
    else
    {
        multa = 0;
    }
    acumulado += multa;
    Console.WriteLine($"Importe a pagar: {multa:C2}");
    PedirVelocidad();
}

Console.WriteLine($"Total acumulado en multas: {acumulado:C2}");