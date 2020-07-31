using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Imprime en consola en dos líneas
            Console.WriteLine("Primera Línea");
            Console.WriteLine("Segunda Línea");

            //Imprime en la misma línea
            Console.Write("Este es un texto");
            Console.Write(" de una sola línea");

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
