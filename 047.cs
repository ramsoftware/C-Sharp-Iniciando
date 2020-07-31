using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            int cont;

            Console.WriteLine("Ciclo ascendente:");
            cont = 0;
            do {
                cont++;

                //Si cont es par entonces va a la siguiente iteración, no 
                //ejecuta lo que está después.
                if (cont % 2 == 0) continue;

                Console.Write(cont.ToString() + ", ");
            } while (cont <= 20);

            Console.ReadKey();
        }
    }
}
