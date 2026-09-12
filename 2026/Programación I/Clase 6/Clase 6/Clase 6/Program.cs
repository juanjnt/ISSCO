/*1 Un sistema de transporte público urbano gestiona el cobro del boleto según el perfil del pasajero. 
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


/*2 Una escuela técnica analiza la asistencia diaria de sus 30 divisiones 
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

/*3 Un inspector municipal realiza controles de velocidad en la avenida 
 * principal de la ciudad, donde el límite máximo permitido es de 60 km/h. 
 * Para cada vehículo controlado se ingresa la velocidad registrada. 
 * Si la velocidad es menor o igual a 60 km/h, no se genera sanción. 
 * Si supera los 60 km/h y llega hasta 80 km/h, se aplica una multa fija de $15.000. 
 * Si supera los 80 km/h, la multa asciende a $35.000. 
 * El control finaliza cuando se ingresa una velocidad igual a 0, 
 * mostrando al terminar la suma total de dinero acumulado en multas.*/

/*int velocidad = 0;
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

Console.WriteLine($"Total acumulado en multas: {acumulado:C2}");*/

//4 Una empresa de viajes de larga distancia liquida las reservas de un micro con
// capacidad para 40 pasajeros. Para cada pasaje vendido se ingresa la categoría
// del asiento (1: Semicama $22.000, 2: Cama $30.000). Si la persona realiza la
// compra con más de 15 días de anticipación, se le otorga un descuento del 10%
// sobre la tarifa base de su asiento. Calcular e imprimir el precio final de cada
// pasaje y, al completar los 40 asientos, mostrar la recaudación total de la unidad.


/*double recaudacionTotal = 0;

for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"--- Pasajero {i} ---");
    Console.Write("Ingrese la categoría del asiento (1: Semicama, 2: Cama): ");
    int categoria = int.Parse(Console.ReadLine());

    Console.Write("Ingrese los días de anticipación de la compra: ");
    int diasAnticipacion = int.Parse(Console.ReadLine());

    double precioFinal = CalcularPrecioPasaje(categoria, diasAnticipacion);
    Console.WriteLine($"Precio final del pasaje: ${precioFinal}");
    
    recaudacionTotal += precioFinal;
}

Console.WriteLine($"Recaudación total de la unidad: ${recaudacionTotal}");

double CalcularPrecioPasaje(int cat, int dias)
{
    double baseTarifa = cat;
    if (cat == 1)
        baseTarifa = 22000;
    else
        baseTarifa = 30000;
    
    if (dias > 15)
    {
        baseTarifa *= 0.90;
    }
    return baseTarifa;
}*/

//5 Una terminal de ómnibus administra el estacionamiento de los colectivos
// en sus plataformas. La primera hora de permanencia tiene un costo de $2.000.
// Si la unidad permanece más de una hora, se cobra un adicional de $1.200 por
// cada hora extra. Luego de obtener el subtotal por tiempo, si el micro pertenece
// a una empresa local, se aplica un descuento del 15% sobre el valor total.
// Imprimir el monto final a pagar por la estadía de la unidad.



/*Console.Write("Ingrese las horas de permanencia: ");
int horas = int.Parse(Console.ReadLine());

Console.Write("¿Pertenece a una empresa local? (1: Sí / 0: No): ");
int esLocal = int.Parse(Console.ReadLine());

double montoFinal = CalcularEstadia(horas, esLocal == 1);
Console.WriteLine($"Monto final a pagar: ${montoFinal}");

double CalcularEstadia(int tiempoHoras, bool esEmpresaLocal)
{
    double subtotal = 2000;
    if (tiempoHoras > 1)
    {
        subtotal += (tiempoHoras - 1) * 1200;
    }

    if (esEmpresaLocal)
    {
        subtotal *= 0.85;
    }

    return subtotal;
}*/

/*6*/

// Un quiosco escolar lleva el control diario de las ventas realizadas
// a los alumnos durante los recreos. En cada transacción se ingresa el
// precio del producto adquirido. El proceso de registro finaliza cuando
// se ingresa un monto igual a 0. Si el importe total acumulado por un alumno
// en esa compra supera los $4.000, se le aplica un descuento automático del 5%.
// Al cortar la carga, mostrar el total definitivo a abonar.



/*double acumulado = 0;

Console.Write("Ingrese el precio del producto (0 para terminar): ");
double precio = double.Parse(Console.ReadLine());

while (precio != 0)
{
    acumulado += precio;
    Console.Write("Ingrese el precio del producto (0 para terminar): ");
    precio = double.Parse(Console.ReadLine());
}

double totalDefinitivo = AplicarDescuentoQuiosco(acumulado);
Console.WriteLine($"Total definitivo a abonar: ${totalDefinitivo}");

double AplicarDescuentoQuiosco(double montoSubtotal)
{
    if (montoSubtotal > 4000)
    {
        return montoSubtotal * 0.95;
    }
    return montoSubtotal;
}*/

/*7*/

// Un centro cultural de la ciudad emite pases para sus talleres semanales
// seleccionados por número de opción (1: Teatro $8.000, 2: Música $10.000,
// 3: Artes Visuales $7.500). Si el participante se inscribe en las opciones
// 1 o 2 y además presenta el carnet de vecino residente (1: Sí / 0: No),
// se le otorga una bonificación fija de $1.500 sobre el costo de la actividad.
// Calcular e imprimir el valor final del taller seleccionado.



/*Console.Write("Ingrese la opción del taller (1: Teatro, 2: Música, 3: Artes Visuales): ");
int opcion = int.Parse(Console.ReadLine());

Console.Write("¿Presenta carnet de vecino residente? (1: Sí / 0: No): ");
int esResidente = int.Parse(Console.ReadLine());

double costoFinal = CalcularCostoTaller(opcion, esResidente == 1);
Console.WriteLine($"Valor final del taller: ${costoFinal}");

double CalcularCostoTaller(int opt, bool vecino)
{
    double costoBase;
    switch (opt)
    {
        case 1:
            costoBase = 8000;
            break;
        case 2:
            costoBase = 10000;
            break;
        case 3:
            costoBase = 7500;
            break;
        default:
            costoBase = 0;
            break;
    }

    if ((opt == 1 || opt == 2) && vecino)
    {
        costoBase -= 1500;
    }

    return costoBase;
}*/

/*8*/

// Un colectivo interurbano realiza su recorrido entre dos ciudades
// con un tanque lleno de 120 litros de combustible. En cada parador
// del trayecto se ingresan los litros consumidos en el tramo. Si en
// alguna parada el combustible restante cae por debajo de los 15 litros,
// el sistema emite una alerta de reserva. Si el consumo ingresado supera el
// saldo disponible en el tanque, la unidad interrumpe el viaje por falta de insumo.
// El monitoreo continúa mientras quede combustible en el tanque o hasta ingresar un
// consumo de 0 litros. Al finalizar, mostrar la cantidad de kilómetros
// equivalentes recorridos a razón de 4 km por litro consumido.



/*double combustibleRestante = 120;
double totalConsumido = 0;

Console.Write("Ingrese litros consumidos en el tramo (0 para finalizar): ");
double consumo = double.Parse(Console.ReadLine());

while (consumo > 0 && combustibleRestante > 0)
{
    if (consumo > combustibleRestante)
    {
        Console.WriteLine("El viaje se interrumpe por falta de combustible.");
        break;
    }

    combustibleRestante -= consumo;
    totalConsumido += consumo;

    VerificarEstadoReserva(combustibleRestante);

    if (combustibleRestante == 0) break;

    Console.Write("Ingrese litros consumidos en el tramo (0 para finalizar): ");
    consumo = double.Parse(Console.ReadLine());
}

double kmTotales = ConvertirLitrosAKilometros(totalConsumido);
Console.WriteLine($"Kilómetros equivalentes recorridos: {kmTotales} km");

void VerificarEstadoReserva(double saldoTanque)
{
    if (saldoTanque < 15 && saldoTanque > 0)
    {
        Console.WriteLine("ALERTA: Combustible en reserva.");
    }
}

double ConvertirLitrosAKilometros(double litros)
{
    return litros * 4;
}*/

/*9*/

// Una biblioteca pública evalúa las solicitudes de préstamo a domicilio
// de sus socios según su historial. Para ser habilitado a retirar un libro,
// el usuario debe presentar su estado de cuenta cuota al día (1: Al día / 0: Moroso).
// Además, debe tener un registro acumulado menor o igual a 2 libros atrasados en el
// año O poseer una antigüedad como socio mayor a 3 años. El programa debe verificar
// las condiciones e imprimir si el préstamo resulta aprobado o denegado.



/*Console.Write("Ingrese estado de cuenta (1: Al día / 0: Moroso): ");
int cuotaAlDia = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de libros atrasados en el año: ");
int librosAtrasados = int.Parse(Console.ReadLine());

Console.Write("Ingrese los años de antigüedad como socio: ");
int antiguedad = int.Parse(Console.ReadLine());

bool esAprobado = EvaluarPrestamo(cuotaAlDia == 1, librosAtrasados, antiguedad);

if(esAprobado)
{
    Console.WriteLine("Préstamo APROBADO.");
}
else
{
    Console.WriteLine("Préstamo DENEGADO.");
}

bool EvaluarPrestamo(bool alDia, int atrasados, int aniosSocio)
{
    return alDia && (atrasados <= 2 || aniosSocio > 3);
}*/




/*10*/

// Un sistema de estacionamiento medido céntrico procesa las tarifas de una
// jornada de 8 horas consecutivas. Por cada hora transcurrida, se ingresa
// la cantidad de vehículos estacionados en ese lapso. Si en una hora determinada
// la cantidad de vehículos es mayor a 50, se considera "Hora Pico" y se aplica una
// tarifa de $1.200 por vehículo para esa hora. Si es menor o igual a 50, la tarifa
// es de $800. Calcular el dinero recaudado en cada hora individual y, al completar
// el turno de 8 horas, mostrar el total general obtenido por el municipio.



/*double totalGeneral = 0;

for (int hora = 1; hora <= 8; hora++)
{
    Console.Write($"Ingrese la cantidad de vehículos en la hora {hora}: ");
    int vehiculos = int.Parse(Console.ReadLine());

    double recaudacionHora = CalcularRecaudacionHora(vehiculos);
    Console.WriteLine($"Recaudación hora {hora}: ${recaudacionHora}");

    totalGeneral += recaudacionHora;
}

Console.WriteLine($"Total general obtenido por el municipio: ${totalGeneral}");

double CalcularRecaudacionHora(int cantidadAutos)
{
    if (cantidadAutos > 50)
    {
        return cantidadAutos * 1200;
    }
    else
    {
        return cantidadAutos * 800;
    }
}*/

/*11*/

// Una estación de servicio calcula el costo de carga de combustible según el tipo
// seleccionado (1: Súper $950/litro, 2: Premium $1.150/litro, 3: Diésel $1.000/litro).
// Se debe ingresar la opción del combustible y la cantidad de litros cargados.
// Si el cliente paga con billetera virtual de la ciudad, obtiene un 10% de
// reintegro sobre el costo total de la carga. Calcular e imprimir el monto final que abona el conductor.



/*Console.Write("Ingrese tipo de combustible (1: Súper, 2: Premium, 3: Diésel): ");
int tipo = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de litros cargados: ");
double litros = double.Parse(Console.ReadLine());

Console.Write("¿Paga con billetera virtual de la ciudad? (1: Sí / 0: No): ");
int usaBilletera = int.Parse(Console.ReadLine());

double montoFinal = CalcularCostoCarga(tipo, litros, usaBilletera == 1);
Console.WriteLine($"Monto final a abonar: ${montoFinal}");

double CalcularCostoCarga(int tipoCombust, double cantidadLitros, bool billetera)
{
    double precioLitro;

    switch (tipoCombust)
    {
        case 1:
            precioLitro = 950;
            break;
        case 2:
            precioLitro = 1150;
            break;
        case 3:
            precioLitro = 1000;
            break;
        default:
            precioLitro = 0;
            break;
    }

    double subtotal = cantidadLitros * precioLitro;

    if (billetera)
    {
        return subtotal * 0.90;
    }
    else
    {
        return subtotal;
    }
}*/

/*12*/

// Un club deportivo controla el ingreso de socios a la pileta climatizada
// durante la temporada escolar. Para ingresar se debe registrar la edad del
// socio y la temperatura corporal leída en la entrada. Si la persona tiene
// más de 60 años O presenta una temperatura menor a 36 grados, se habilita el
// acceso a la zona de vapor terapéutico sin cargo adicional. En caso contrario,
// abona una entrada general de $2.500. El programa debe evaluar la condición y
// mostrar el importe exacto a abonar.


/*Console.Write("Ingrese la edad del socio: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("Ingrese la temperatura corporal leída: ");
double temperatura = double.Parse(Console.ReadLine());

double entrada = EvaluarIngresoPileta(edad, temperatura);

if (entrada == 0)
{
    Console.WriteLine("Acceso habilitado a zona de vapor terapéutico sin cargo adicional.");
    Console.WriteLine("Importe a abonar: $0");
}
else
{
    Console.WriteLine($"Importe a abonar (Entrada General): ${entrada}");
}

double EvaluarIngresoPileta(int edadSocio, double temp)
{
    if (edadSocio > 60 || temp < 36) 
        return 0;
    return 2500;
}*/

/*13*/

// Un municipio otorga subsidios a las familias para el transporte escolar
// en colectivo. Para determinar el beneficio se solicita la cantidad de hijos
// en edad escolar y la distancia en kilómetros desde el hogar hasta la escuela.
// Si la familia tiene más de 2 hijos Y vive a una distancia mayor a 5 km, se
// asigna un subsidio del 100% (transporte gratuito). Si se cumple únicamente una
// de las dos condiciones, el subsidio es del 50%. Si no cumple ninguna, no se
// otorga beneficio. Mostrar la categoría de subsidio asignada.



/*Console.Write("Ingrese la cantidad de hijos en edad escolar: ");
int hijos = int.Parse(Console.ReadLine());

Console.Write("Ingrese la distancia a la escuela (en km): ");
double distancia = double.Parse(Console.ReadLine());

string resultado = ObtenerCategoriaSubsidio(hijos, distancia);
Console.WriteLine($"Categoría de subsidio: {resultado}");

string ObtenerCategoriaSubsidio(int numHijos, double distKm)
{
    bool condHijos = numHijos > 2;
    bool condDistancia = distKm > 5;

    if (condHijos && condDistancia) 
        return "100% (Transporte Gratuito)";
    if (condHijos || condDistancia) 
        return "50%";
    return "Sin beneficio (0%)";
}*/

/*14*/

// Una empresa de viajes grupales cotiza traslados para contingentes
// escolares hacia un parque recreativo. Se ingresa el valor base del
// viaje por alumno. Si el grupo está integrado por más de 30 estudiantes
// Y el viaje se realiza entre los meses de marzo y julio, se aplica un
// descuento del 20% al valor del pasaje de cada alumno. Si el grupo es de
// 30 o menos, el precio se mantiene sin cambios. Calcular y mostrar el
// costo por estudiante y el monto global del contingente.



/*Console.Write("Ingrese el valor base por alumno: ");
double valorBase = double.Parse(Console.ReadLine()!);

Console.Write("Ingrese la cantidad de estudiantes: ");
int cantidadEstudiantes = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el número de mes del viaje (1 al 12): ");
int mes = int.Parse(Console.ReadLine()!);

double costoPorEstudiante = CalcularCostoAlumno(valorBase, cantidadEstudiantes, mes);
double montoGlobal = costoPorEstudiante * cantidadEstudiantes;

Console.WriteLine($"Costo por estudiante: ${costoPorEstudiante}");
Console.WriteLine($"Monto global del contingente: ${montoGlobal}");

double CalcularCostoAlumno(double tarifaBase, int cantidad, int mesViaje)
{
    if (cantidad > 30 && mesViaje >= 3 && mesViaje <= 7)
    {
        return tarifaBase * 0.80;
    }
    return tarifaBase;
}*/

/*15*/

// Un peaje urbano procesa el pase de una fila de vehículos en una
// cabina automática. Se solicita ingresar el tipo de pase de cada
// vehículo ("TAG", "EFECTIVO" o "EXENTO"). Si es "TAG", cobra $600.
// Si es "EFECTIVO", cobra $900. Si es "EXENTO", no cobra nada ($0).
// El proceso se repite continuamente hasta que el operador ingresa
// la palabra "FIN", momento en el que el programa debe imprimir la
// cantidad total de vehículos procesados y el dinero recaudado en la cabina.


/*int vehiculosProcesados = 0;
double dineroRecaudado = 0;

Console.Write("Ingrese tipo de pase (TAG, EFECTIVO, EXENTO o FIN): ");
string tipoPase = Console.ReadLine().ToUpper();

while (tipoPase != "FIN")
{
    double cobro = ProcesarTarifaPeaje(tipoPase);
    if (cobro >= 0)
    {
        dineroRecaudado += cobro;
        vehiculosProcesados++;
    }
    else
    {
        Console.WriteLine("Tipo de pase no reconocido.");
    }

    Console.Write("Ingrese tipo de pase (TAG, EFECTIVO, EXENTO o FIN): ");
    tipoPase = Console.ReadLine().ToUpper();
}

Console.WriteLine($"Cantidad total de vehículos procesados: {vehiculosProcesados}");
Console.WriteLine($"Dinero total recaudado: ${dineroRecaudado}");

double ProcesarTarifaPeaje(string pase)
{
    double tarifa;

    switch (pase)
    {
        case "TAG":
            tarifa = 600;
            break;
        case "EFECTIVO":
            tarifa = 900;
            break;
        case "EXENTO":
            tarifa = 0;
            break;
        default:
            tarifa = -1;
            break;
    }

    return tarifa;
}*/

/*16*/

// Un inspector de transporte escolar fiscaliza un lote cerrado de
// 12 minibuses en la puerta de los colegios. Para cada unidad se
// ingresa la cantidad de asientos disponibles y la cantidad de
// niños a bordo. Si la cantidad de niños supera la capacidad de
// asientos, se registra como "Infracción por sobrecupo". Al terminar
// de revisar los 12 vehículos, el programa debe mostrar cuántas unidades
// circulaban en regla y cuántas registraron infracción.


/*int enRegla = 0;
int conInfraccion = 0;

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"--- Minibús {i} ---");
    Console.Write("Ingrese la cantidad de asientos disponibles: ");
    int asientos = int.Parse(Console.ReadLine());

    Console.Write("Ingrese la cantidad de niños a bordo: ");
    int ninos = int.Parse(Console.ReadLine());

    if (EsInfraccion(asientos, ninos))
    {
        Console.WriteLine("Infracción por sobrecupo");
        conInfraccion++;
    }
    else
    {
        enRegla++;
    }
}

Console.WriteLine($"Unidades en regla: {enRegla}");
Console.WriteLine($"Unidades con infracción: {conInfraccion}");

bool EsInfraccion(int capacidad, int pasajeros)
{
    if (pasajeros > capacidad)
    {
        return true;
    }
    else
    {
        return false;
    }
}*/

/*17*/

// Un comercio del centro de la ciudad liquida la factura de una compra ingresando
// los precios de los productos uno por uno. El ingreso de datos finaliza al cargar
// un precio igual a 0. Si el subtotal de la compra supera los $20.000 Y el cliente
// abona en efectivo, se aplica un descuento de $2.500 sobre el valor acumulado. En
// caso contrario, se cobra el valor neto acumulado. Mostrar el saldo final a pagar en caja.



/*double subtotal = 0;

Console.Write("Ingrese precio del producto (0 para finalizar): ");
double precio = double.Parse(Console.ReadLine());

while (precio != 0)
{
    subtotal += precio;
    Console.Write("Ingrese precio del producto (0 para finalizar): ");
    precio = double.Parse(Console.ReadLine());
}

Console.Write("¿Abona en efectivo? (1: Sí / 0: No): ");
int esEfectivo = int.Parse(Console.ReadLine());

double saldoFinal = CalcularSaldoFinalComercio(subtotal, esEfectivo == 1);
Console.WriteLine($"Saldo final a pagar en caja: ${saldoFinal}");

double CalcularSaldoFinalComercio(double monto, bool pagoEfectivo)
{
    if (monto > 20000 && pagoEfectivo)
    {
        return monto - 2500;
    }
    return monto;
}
*/

/*18*/

// Un sistema de bicicletas públicas de la ciudad registra el uso continuo de las unidades
// entregadas durante el día. Cada vez que se devuelve una bicicleta, se ingresa la cantidad
// de minutos que fue utilizada. El proceso de registro finaliza al ingresar un tiempo igual
// a 0 minutos. Si el tiempo de uso supera los 45 minutos, se cobra una penalización de $100
// por cada minuto excedente sobre ese límite. Al cortar el sistema, imprimir la cantidad de
// viajes que excedieron el límite permitido.


/*
int viajesExcedidos = 0;

Console.Write("Ingrese los minutos de uso (0 para finalizar): ");
int minutos = int.Parse(Console.ReadLine());

while (minutos != 0)
{
    double penalizacion = CalcularPenalizacionBicicleta(minutos);
    if (penalizacion > 0)
    {
        Console.WriteLine($"Viaje excedido. Penalización: ${penalizacion}");
        viajesExcedidos++;
    }

    Console.Write("Ingrese los minutos de uso (0 para finalizar): ");
    minutos = int.Parse(Console.ReadLine());
}

Console.WriteLine($"Cantidad de viajes que excedieron el límite: {viajesExcedidos}");

double CalcularPenalizacionBicicleta(int minutosUso)
{
    if (minutosUso > 45)
    {
        return (minutosUso - 45) * 100;
    }
    return 0;
}
*/

/*19*/

// Una oficina municipal de licencias liquida el costo de emisión de los carnets
// de conducir según la vigencia otorgada (1 año: $5.000, 3 años: $12.000, 5 años: $18.000).
// Si el solicitante es mayor o igual a 70 años, la vigencia es automáticamente de 1 año y
// se le aplica un descuento del 50% sobre esa tarifa. Calcular e imprimir el importe
// exacto del trámite a abonar en tesorería.



/*Console.Write("Ingrese la edad del solicitante: ");
int edad = int.Parse(Console.ReadLine());

int vigenciaDeseada = 1;
if (edad < 70)
{
    Console.Write("Ingrese la vigencia deseada (1, 3 o 5 años): ");
    vigenciaDeseada = int.Parse(Console.ReadLine());
}

double importeFinal = LiquidarLicencia(edad, vigenciaDeseada);
Console.WriteLine($"Importe exacto a abonar en tesorería: ${importeFinal}");

double LiquidarLicencia(int edadPersona, int vigencia)
{
    if (edadPersona >= 70)
    {
        return 5000 * 0.50;
    }

    switch (vigencia)
    {
        case 1:
            return 5000;
        case 2: 
        case 3:
            return 12000;
        case 5:
            return 18000;
        default:
            return 0;
    }
}
*/
/*20*/


// Un servicio de colectivos nocturnos evalúa la cantidad de pasajeros a lo largo
// de un recorrido de 10 paradas fijas. En cada parada se ingresa cuántos pasajeros
// suben y cuántos bajan. El colectivo inicia el recorrido con 0 pasajeros.
// Si en alguna parada la suma de pasajeros a bordo supera la capacidad máxima de
// 50 personas, el sistema debe imprimir un aviso de "Unidad Completa". Al finalizar
// la décima parada, mostrar la cantidad de pasajeros que continúan en el colectivo al llegar a la cabecera.



int pasajerosABordo = 0;

for (int parada = 1; parada <= 10; parada++)
{
    Console.WriteLine($"--- Parada {parada} ---");
    Console.Write("Pasajeros que suben: ");
    int suben = int.Parse(Console.ReadLine());

    Console.Write("Pasajeros que bajan: ");
    int bajan = int.Parse(Console.ReadLine());

    pasajerosABordo = ActualizarPasajeros(pasajerosABordo, suben, bajan);

    if (EsUnidadCompleta(pasajerosABordo))
    {
        Console.WriteLine("Unidad Completa");
    }
}

Console.WriteLine($"Pasajeros que continúan al llegar a la cabecera: {pasajerosABordo}");

int ActualizarPasajeros(int actuales, int suben, int bajan)
{
    return actuales + suben - bajan;
}

bool EsUnidadCompleta(int pas)
{
    return pas > 50;
}