using System;

namespace Ejemplo_007___intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe tu nombre y presiona INTRO: ");
            string Nombre = Console.ReadLine();
            Console.Write("Escribe tu edad y presiona INTRO: ");
            string edad = Console.ReadLine();
            Console.WriteLine($"Hola {Nombre}, tienes buena pinta para tu edad de {edad} años.");
        }
    }
}
