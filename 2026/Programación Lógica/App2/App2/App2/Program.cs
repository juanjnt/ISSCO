/*2- Estás jugando un juego y te enfrentás al jefe final, 
 * que arranca con 500 puntos de vida (HP). 
 * Mientras la vida del jefe sea mayor a 0, tu personaje 
 * va a realizar un ataque por turno. 
 * En cada turno, debés pedirle al usuario que ingrese el 
 * tipo de ataque realizado (escribiendo un string: "NORMAL", "ESPECIAL" o "FALLIDO"):
Si el ataque es "NORMAL", el jefe pierde 50 HP.
Si el ataque es "ESPECIAL", calculás un golpe crítico: el jefe pierde 120 HP.
Si el ataque es "FALLIDO", el jefe no pierde vida (0 HP) y 
se muestra el mensaje "¡Esquivado!".
Al salir del bucle (cuando la vida del jefe llega a 0 o menos), 
mostrar en pantalla: "¡Victoria! El jefe ha sido derrotado".*/


/*using System.ComponentModel.Design;

int jefe = 500;
string golpe = string.Empty;
while (jefe > 0)
{
    Console.WriteLine("Ingrese el tipo de ataque");
    Console.WriteLine("NORMAL, ESPECIAL o FALLIDO");
    golpe = Console.ReadLine().ToUpper();
    if (golpe == "NORMAL")
    {
        jefe = jefe - 50;
    }
    else if (golpe == "ESPECIAL")
    { 
        Console.WriteLine("¡Golpe crítico!");
        jefe = jefe - 120;
    }
    else if (golpe == "FALLIDO")
    {
        Console.WriteLine("¡Esquivado!");
    }
    else
    {
        Console.WriteLine("Tipo de ataque no válido. Intente de nuevo.");
    }
    Console.WriteLine($"La vida del jefe es: {jefe} HP");
}

Console.WriteLine("¡Victoria! El jefe ha sido derrotado");*/

/*
int consumo = 0;
int combustible = 60;


while (combustible > 0)
{
    Console.WriteLine("Ingrese el consumo de combustible");
    consumo = int.Parse(Console.ReadLine());
    combustible = combustible - consumo;
}
*/

/*3- Sos el encargado de controlar el ingreso a un boliche 
 * que tiene una capacidad máxima estricta de 200 personas. 
 * El boliche arranca vacío. Mientras la cantidad de personas 
 * adentro sea menor a 200, se van arrimando grupos a la puerta. 
 * En cada paso, debés pedir que ingresen la cantidad de personas 
 * de ese grupo y si tienen entrada en mano (string: "SI" o "NO").
Si responden "NO", el grupo no puede pasar y mostrás: 
"Acceso denegado: Sin entrada".
Si responden "SI", debés verificar si el grupo entra en 
el lugar disponible. Si la suma de las personas de ese 
grupo más las que ya están adentro supera las 200 personas, 
mostrás: "Capacidad insuficiente, deben esperar". 
Si el grupo entra perfectamente, los sumás al total y 
mostrás el espacio disponible que queda.
Al llenarse el boliche (llegar exactamente a 200), el
bucle termina y muestra: "¡Capacidad completa! Puertas cerradas".*/

int capacidad = 0;
int grupo = 0, personas = 0;

while (capacidad < 200)
{
    Console.WriteLine("Tienen entradas en mano? 1- Si / 2- No");
    int respuesta = int.Parse(Console.ReadLine());
    if (respuesta == 1)
    { 
        Console.WriteLine("Ingrese la cantidad de personas del grupo");
        grupo = int.Parse(Console.ReadLine());
        if (capacidad + grupo > 200)
        {
            Console.WriteLine("Capacidad insuficiente, deben esperar");
        }
        else
        {
            capacidad = capacidad + grupo;
        }
        if (capacidad == 200)
        {
            Console.WriteLine("¡Capacidad completa! Puertas cerradas");
        }
    }
    else
    {
        Console.WriteLine("Acceso denegado: Sin entrada");
    }

}