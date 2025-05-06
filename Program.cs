using System;

namespace ColegioApp
{
class Program
{
    static void Main()
    {
        // Crear una persona
        Persona persona = new Persona("Ana García", "98765432L", new DateTime(1990, 6, 25));

        // Asociar a un jugador (agregación)
        Jugador jugador = new Jugador(12345, persona);

        // Mostrar datos del jugador y su persona asociada
        jugador.MostrarDatosJugador();
    }
}

}