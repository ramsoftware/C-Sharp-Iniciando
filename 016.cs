using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            /* Orden de evaluación de los operadores:
             * Primero potencia
             * Segundo multiplicación y división
             * Tercero suma y resta
             * */
            double valA = (double)7 - 1 + 2 * Math.Pow(2, 5) / 4;
            double valB = (double)1 + 2 * 3 / 4 - 5;
            double valC = (double)3 + 5 - 2 * 4 / 8;
            double valD = (double)3 * 2 + 5 / 10 - 2 * Math.Pow(3, 2) + 4 * 4 / 8;

            Console.WriteLine("Valor A es: " + valA.ToString());
            Console.WriteLine("Valor B es: " + valB.ToString());
            Console.WriteLine("Valor C es: " + valC.ToString());
            Console.WriteLine("Valor D es: " + valD.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
