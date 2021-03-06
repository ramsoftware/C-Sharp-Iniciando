using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Lee dos números por consola
            Console.Write("Escriba un primer número: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba un segundo número: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            //Si condicional
            if (valorA > valorB) {
                Console.WriteLine(valorA.ToString() + " es mayor que " + valorB.ToString());
            }
            else if (valorA < valorB) {
                Console.WriteLine(valorA.ToString() + " es menor que " + valorB.ToString());
            }
            else {
                Console.WriteLine(valorA.ToString() + " es igual a " + valorB.ToString());
            }

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
