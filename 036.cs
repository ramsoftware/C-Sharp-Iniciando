using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Tabla del AND
            Console.WriteLine("\r\nTabla del operador AND");
            Console.WriteLine(true & true);
            Console.WriteLine(true & false);
            Console.WriteLine(false & true);
            Console.WriteLine(false & false);

            //Tabla del OR
            Console.WriteLine("\r\nTabla del operador OR");
            Console.WriteLine(true | true);
            Console.WriteLine(true | false);
            Console.WriteLine(false | true);
            Console.WriteLine(false | false);

            //Tabla del XOR
            Console.WriteLine("\r\nTabla del operador XOR");
            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ true);
            Console.WriteLine(false ^ false);

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}