using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo string
            string cadenaA = "Esta es una prueba";
            string cadenaB = "Programando en C#";
            string cadenaC = "Con Visual Studio 2019";

            //Imprime esas variables
            Console.WriteLine("Cadena A es: " + cadenaA);
            Console.WriteLine("Cadena B es: " + cadenaB);
            Console.WriteLine("Cadena C es: " + cadenaC);

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}