using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo double
            double valA = 17902.8421;
            double valB = -871901372.420821098765;
            double valC = 89341759342.1678;

            //Imprime con un formato de miles
            Console.WriteLine("Valor A es: {0:0,0.0}", valA);
            Console.WriteLine("Valor A es: {0:0,0.000}", valA);

            Console.WriteLine("Valor B es: {0:0,0.0}", valB);
            Console.WriteLine("Valor B es: {0:0,0.000}", valB);

            Console.WriteLine("Valor C es: {0:0,0.0}", valC);
            Console.WriteLine("Valor C es: {0:0,0.000}", valC);

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
