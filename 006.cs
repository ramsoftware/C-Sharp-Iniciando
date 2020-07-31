using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Declara variables de tipo char
            char letraA = 'R';
            char letraB = 'a';
            char letraC = 'f';

            //Imprime esas variables
            Console.WriteLine("Letra A es: " + letraA.ToString());
            Console.WriteLine("Letra B es: " + letraB.ToString());
            Console.WriteLine("Letra C es: " + letraC.ToString());

            //Esta instrucción detiene que se cierre la ventana de consola
            Console.ReadKey();
        }
    }
}