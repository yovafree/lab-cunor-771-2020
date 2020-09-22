using System;

namespace CAEjemplo1
{
    class Program
    {
        static int num1=5;

        /***
         * Esto es un comentario de documentación 
         * nos ayuda a mejorar la visibilidad de una descripción.
         */
        static void Main(string[] args)
        {
            num1 = -3;
            num1 = 0;

            #region "Uso de IF"
            // IF
            if (num1 > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else if (num1 == 0) {
                Console.WriteLine("Es cero");
            }
            else
            {
                Console.WriteLine("Es negativo");
            }
            #endregion

            num1 = 10;
            #region "Uso de Switch"
            switch (num1) {
                case 0:
                    Console.WriteLine("El valor es 0");
                    break;
                case 1:
                    Console.WriteLine("El valor es 1");
                    break;
                case 2:
                    Console.WriteLine("El valor es 2");
                    break;
                default:
                    Console.WriteLine("El valor es default");
                    break;
            }
            #endregion

            Console.ReadKey();
        }
    }
}
