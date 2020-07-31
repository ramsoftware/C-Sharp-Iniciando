using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo double
            double valA = 2.76;
            double valB = 2.04;
            double valC = 0.14;

            //Imprime si la cifra es significativa (redondea también)
            Console.WriteLine("Valor A es: {0:#.#}", valA);
            Console.WriteLine("Valor B es: {0:#.#}", valB);
            Console.WriteLine("Valor C es: {0:#.#}", valC);

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}