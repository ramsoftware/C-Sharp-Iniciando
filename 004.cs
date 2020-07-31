using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo entero
            int ladoA = 4;
            int ladoB = 8;
            int ladoC = 10;

            //Imprime esas variables
            Console.WriteLine("Lado A es: " + ladoA.ToString());
            Console.WriteLine("Lado B es: " + ladoB.ToString());
            Console.WriteLine("Lado C es: " + ladoC.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}