using System;

namespace Ejemplo {
    class Program {
        static int valor; //Una variable que es conocida por todas las funciones

        static void Main(string[] args) {
            //Ámbito de las variables
            valor = 17;
            Console.WriteLine("Valor es: " + valor.ToString());
            UnProcedimiento();
            Console.WriteLine("Valor es: " + valor.ToString());
            OtroProcedimiento();
            Console.WriteLine("Valor es: " + valor.ToString());
            Console.ReadKey();
        }

        //Un procedimiento
        static void UnProcedimiento() {
            valor = 853;
        }

        //Otro procedimiento
        static void OtroProcedimiento() {
            valor = 987654321;
        }
    }
}
