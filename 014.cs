using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Compara la precisión entre float y double
            float valA = (float) (1.7 / 2.8 * 4.8 / 6.7 / 5.3);
            double valB = 1.7 / 2.8 * 4.8 / 6.7 / 5.3;

            Console.WriteLine("Valor A es: " + valA.ToString());
            Console.WriteLine("Valor B es: " + valB.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
