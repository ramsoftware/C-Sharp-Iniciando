using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo double
            double valA = 5.718987654321;
            double valB = -3.420821098765;
            double valC = 1.234567890123456789;
            double valD = 7.8;

            //Imprime con un formato de al menos dos decimales
            Console.WriteLine("Valor A es: {0:0.00}", valA);

            //Imprime con un formato de al menos tres decimales
            Console.WriteLine("Valor B es: {0:0.000}", valB);

            //Imprime con un formato de al menos cuatro decimales
            Console.WriteLine("Valor C es: {0:0.0000}", valC);

            //Imprime con un formato de al menos cinco decimales
            Console.WriteLine("Valor D es: {0:0.00000}", valD);

            /* Imprime las tres variables. Ver el inicio {N: donde N es la posición de la variable
             * en la instrucción de impresión iniciando en cero. */
            Console.WriteLine("valA: {0:0.00}; valB: {1:0.00}; valC: {2:0.00}", valA, valB, valC);

            /* Máximo tres decimales */
            Console.WriteLine("Valor C con máximo tres decimales es: {0:0.###}", valC);
            Console.WriteLine("Valor D con máximo tres decimales es: {0:0.###}", valD);

            /* Mínimo tres digitos antes del punto decimal */
            Console.WriteLine("Valor A con tres digitos antes del punto decimal: {0:000.###}", valA);
            Console.WriteLine("Valor B con tres digitos antes del punto decimal: {0:000.###}", valB);

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
