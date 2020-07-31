using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            int cont;

            //Ciclo while ascendente
            Console.WriteLine("Ciclo ascendente:");
            cont = 1;
            while(cont<=20) {
                Console.Write(cont.ToString() + ", ");
                cont++;
            }

            //Ciclo while descendente
            Console.WriteLine("\r\nCiclo descendente:");
            cont = 20;
            while (cont >= 1) {
                Console.Write(cont.ToString() + ", ");
                cont--;
            }

            //Ciclo while ascendente, avance de 2 en 2
            Console.WriteLine("\r\nCiclo ascendente (avance de 2 en 2):");
            cont = 1;
            while (cont <= 20) {
                Console.Write(cont.ToString() + ", ");
                cont += 2;
            }

            //Ciclo while descendente, retrocede de 2 en 2
            Console.WriteLine("\r\nCiclo descendente (retrocede de 2 en 2):");
            cont = 20;
            while (cont >= 1) {
                Console.Write(cont.ToString() + ", ");
                cont -= 2;
            }

            //Ciclo while ascendente, avance doble
            Console.WriteLine("\r\nCiclo ascendente (avance doble):");
            cont = 1;
            while (cont <= 20) {
                Console.Write(cont.ToString() + ", ");
                cont *= 2;
            }

            //Ciclo while descendente, retrocede la mitad
            Console.WriteLine("\r\nCiclo descendente (retrocede la mitad):");
            cont = 20;
            while (cont >= 1) {
                Console.Write(cont.ToString() + ", ");
                cont /= 2;
            }

            Console.ReadKey();
        }
    }
}
