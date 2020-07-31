using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Generando números al azar.
            Random azar = new Random(); //La semilla del generador la define el .Net framework

            //Números enteros al azar
            Console.Write("Enteros positivos: ");
            for (int cont=1; cont<=10; cont++) {
                int numEntero = azar.Next();
                Console.Write(numEntero.ToString() + " | ");
            }

            //Números entre 0 y 1 al azar
            Console.Write("\r\n\r\nReales: ");
            for (int cont = 1; cont <= 10; cont++) {
                double numReal = azar.NextDouble();
                Console.Write(numReal.ToString() + " | ");
            }

            //Números entre 15 y 44 al azar.
            Console.Write("\r\n\r\nEnteros positivos entre 15 y 44: ");
            for (int cont = 1; cont <= 10; cont++) {
                int numEntero = azar.Next(15, 45); //El segundo parámetro debe ser +1 del rango máximo que se busca
                Console.Write(numEntero.ToString() + " | ");
            }

            //Generando los mismos valores
            Console.Write("\r\n\r\nGenerando los mismos valores: ");
            Random AleatorioA = new Random(500);
            Random AleatorioB = new Random(500);
            for (int cont=1; cont<=20; cont++) {
                int numA = AleatorioA.Next(55, 95);
                int numB = AleatorioB.Next(55, 95);
                Console.Write(numA.ToString() + " y " + numB.ToString() + " | ");
            }

            Console.ReadKey();
        }
    }
}
