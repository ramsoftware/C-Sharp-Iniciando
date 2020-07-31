using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Lee los lados de un triángulo
            Console.Write("Escriba valor lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba valor lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escriba valor lado C: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            //Si condicional, uso del OR ||
            if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC) {
                Console.WriteLine("Triángulo equilátero o isósceles");
            }
            else {
                Console.WriteLine("Triángulo escaleno");
            }

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
