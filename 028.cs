using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Leer un número por consola
            Console.Write("Escriba un número: ");
            double valorReal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribió: " + valorReal.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
