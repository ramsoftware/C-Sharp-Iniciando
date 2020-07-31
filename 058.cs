using System;

namespace Ejemplo {
    class Program {
        static void Main(string[] args) {
            //Ámbito de las variables. Variable local
            int valor = 17;
            Console.WriteLine("Valor es: " + valor.ToString());
            UnProcedimiento();
            Console.WriteLine("Valor es: " + valor.ToString());
            OtroProcedimiento();
            Console.WriteLine("Valor es: " + valor.ToString());
            Console.ReadKey();
        }

        //Un procedimiento. La variable “valor” es otra distinta a la del “Main”
        static void UnProcedimiento() {
            int valor = 853;
        }

        //Otro procedimiento. La variable “valor” es otra distinta a la del “Main”
        static void OtroProcedimiento() {
            int valor = 987654321;
        }
    }
}
