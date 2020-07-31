using System;
using System.Globalization; //Nueva librería

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Fallos de conversión
            string valA = ""; //Una cadena nula o vacía daña la conversión

            //El programa se cae
            double valB = Convert.ToDouble(valA);
            Console.WriteLine("Valor B es: " + valB.ToString());

            //El programa se cae
            double valF = double.Parse(valA, CultureInfo.InvariantCulture);
            Console.WriteLine("Valor F es: " + valF.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}
