using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Enviando el objeto aleatorio como parámetro
            Random azar = new Random();

            ProcedimientoA(azar);
            Console.WriteLine(" ");
            ProcedimientoB(azar);
            Console.ReadKey();
        }

        static void ProcedimientoA(Random azar) {
            for (int num=1; num<=10; num++) {
                Console.Write(azar.Next(1, 30).ToString() + " , ");
            }
        }

        static void ProcedimientoB(Random azar) {
            for (int num = 1; num <= 10; num++) {
                Console.Write(azar.Next(1, 30).ToString() + " , ");
            }
        }

    }
}
