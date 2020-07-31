using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Ciclo for ascendente
            Console.WriteLine("Ciclo ascendente:");
            for (int cont=1; cont<=20; cont++) {
                Console.Write(cont.ToString() + ", ");
            }

            //Ciclo for descendente
            Console.WriteLine("\r\nCiclo descendente:");
            for (int cont = 20; cont >= 1; cont--) {
                Console.Write(cont.ToString() + ", ");
            }

            //Ciclo for ascendente, avance de 2 en 2
            Console.WriteLine("\r\nCiclo ascendente (avance de 2 en 2):");
            for (int cont = 1; cont <= 20; cont+=2) {
                Console.Write(cont.ToString() + ", ");
            }

            //Ciclo for descendente, retrocede de 2 en 2
            Console.WriteLine("\r\nCiclo descendente (retrocede de 2 en 2):");
            for (int cont = 20; cont >= 1; cont -= 2) {
                Console.Write(cont.ToString() + ", ");
            }

            //Ciclo for ascendente, avance doble
            Console.WriteLine("\r\nCiclo ascendente (avance doble):");
            for (int cont = 1; cont <= 20; cont *= 2) {
                Console.Write(cont.ToString() + ", ");
            }

            //Ciclo for descendente, retrocede la mitad
            Console.WriteLine("\r\nCiclo descendente (retrocede la mitad):");
            for (int cont = 20; cont >= 1; cont /= 2) {
                Console.Write(cont.ToString() + ", ");
            }

            Console.ReadKey();
        }
    }
}
