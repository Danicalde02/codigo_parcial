using System;

namespace ColegioApp
{
public class Jugador
{
    public int NumFed { get; set; }
    public Persona PersonaAsociada { get; set; }  // Agregación

    public Jugador(int numFed, Persona persona)
    {
        NumFed = numFed;
        PersonaAsociada = persona;
    }

    public void MostrarDatosJugador()
    {
        Console.WriteLine($"Número de Federación: {NumFed}");
        PersonaAsociada.MostrarDatos();
    }
}

}