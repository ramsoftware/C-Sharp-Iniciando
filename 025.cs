using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Funciones hiperbólicas
            double valorReal = -5.4713;

            double valSenoH = Math.Sinh(valorReal);
            double valCosenoH = Math.Cosh(valorReal);
            double valTangenteH = Math.Tanh(valorReal);

            Console.WriteLine("Valor: " + valorReal.ToString());
            Console.WriteLine("Seno hiperbólico es: " + valSenoH.ToString());
            Console.WriteLine("Coseno hiperbólico es: " + valCosenoH.ToString());
            Console.WriteLine("Tangente hiperbólico es: " + valTangenteH.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}