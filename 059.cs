using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Valores al azar PERO que dan la misma sucesión
            ProcedimientoA();
            Console.WriteLine(" ");
            ProcedimientoB();
            Console.ReadKey();
        }

        static void ProcedimientoA() {
            Random azar = new Random();
            for (int num=1; num<=10; num++) {
                Console.Write(azar.Next(1, 30).ToString() + " , ");
            }
        }

        static void ProcedimientoB() {
            Random azar = new Random();
            for (int num = 1; num <= 10; num++) {
                Console.Write(azar.Next(1, 30).ToString() + " , ");
            }
        }

    }
}
