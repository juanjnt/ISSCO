
using Clase9.Libreria;

//Persona persona = new Persona("Juan", "Tagliavini", 38);
Persona persona = new Persona();
persona.Nombre = "Juan";
persona.Apellido = "Tagliavini";
persona.Edad = 38;

Persona persona1 = new Persona()
{
    Nombre = "Kevin",
    Apellido = "Torrez",
    Edad = 20
};



List<Persona> listaPersona = new List<Persona>();

listaPersona.Add(persona); 