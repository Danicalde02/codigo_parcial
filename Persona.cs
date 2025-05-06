using System;

namespace Parcial
{

public class Persona
{
    public string Nombre { get; set; }
    public string Nif { get; set; }
    public DateTime FechaNac { get; set; }

    public Persona(string nombre, string nif, DateTime fechaNac)
    {
        Nombre = nombre;
        Nif = nif;
        FechaNac = fechaNac;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"NIF: {Nif}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNac.ToShortDateString()}");
    }
}

}