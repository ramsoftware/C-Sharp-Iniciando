using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            int cont;

            //Rompe el ciclo con break
            Console.WriteLine("Ciclo ascendente:");
            cont = 1;
            do {
                //Si cont es múltiplo de 13 se rompe el ciclo con break
                if (cont % 13 == 0) break;
                Console.Write(cont.ToString() + ", ");
                cont++;
            } while (cont <= 20);

            Console.ReadKey();
        }
    }
}
