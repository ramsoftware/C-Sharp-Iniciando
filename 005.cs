using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo double
            double valA = 5.718987654321;
            double valB = 3.420321098765;
            double valC = 1.23456789012345678901234567890123456789012345678901234567890123456789;

            //Imprime esas variables
            Console.WriteLine("Valor A es: " + valA.ToString());
            Console.WriteLine("Valor B es: " + valB.ToString());
            Console.WriteLine("Valor C es: " + valC.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}