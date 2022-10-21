/*Calcular cantidad de materiales
    Obtener metros cuadrados a construir
        Calcular cantidad de ladrillos (16 x m2)
        Calcular cantidad de arena (m2 / 20)
        Calcular cantidad de cemento (arena * 3)
        Calcular costo materiales
    Obtener precio de materiales
        Calcular cantidad de materiales por precio obtenido
    Calcular costo mano de obra
        Calcular (total materiales x 0.85).
    Calcular presupuesto
        mano de obra + costo materiales.
*/


Inicio();

void Inicio()
{
    Console.WriteLine("Indique total de metros cuadrados a construir");
    int metros = Convert.ToInt32(Console.ReadLine());
    Calculo(metros);
    Inicio();
}




void Calculo(int metros)
{
    decimal ladrillos = metros * 16;
    decimal arena = metros / 20;              
    decimal cemento = arena * 3;

    Console.WriteLine("Indique precio del ladrillo");
    decimal precioLadrillo = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Indique precio de la arena");
    decimal precioArena = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Indique precio del cemento");
    decimal precioCemento = Convert.ToDecimal(Console.ReadLine());

    decimal totalObra = (ladrillos * precioLadrillo) + (arena * precioArena) + (cemento * precioCemento);
    decimal manoObra = totalObra * (decimal)0.85;

    decimal presupuesto = totalObra + manoObra;
    Console.WriteLine("Presupuesto: $" + presupuesto);
    Console.ReadLine();

}