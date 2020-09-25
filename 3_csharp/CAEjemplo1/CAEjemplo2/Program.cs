using System;

namespace CAEjemplo2
{
    class Program
    {
        static Funciones fnc = new Funciones();
        static void Main(string[] args)
        {
            //hola();
            //calculos();

            Console.WriteLine("Ingrese el número");

            string valor = Console.ReadLine();

            Console.WriteLine(fnc.DecABin(int.Parse(valor)));

            /* 
             Tarea: Realizar un conversor de base en C# con Consola. Deberá de permitir
             realizar las siguientes conversiones:

            Decimal a Binario
            Binario a Decimal
            Decimal a Hexadecimal
            Hexadecimal a Decimal
            Binario a Hexadecimal
            Hexadecimal a Binario
            Octal a Hexadecimal
            Hexadecimal a Octal

            Texto a Binario
            Binario a Texto.

            Eje: "Hola Mundo" -> 01001000 01101111 01101100 01100001 00100000 01001101 01110101 01101110 01100100 01101111
             */

            Console.ReadKey();
        }

        #region "Uso de métodos - Calculos"
        static void hola()
        {
            Console.WriteLine("Hola mundo");
        }

        static void calculos() {
            int resu = suma(3, 8);
            Console.WriteLine("La suma es: " + resu);

            int resu2 = resta(3, 8);
            Console.WriteLine("La resta es: " + resu2);

            int resu3 = multi(3, 8);
            Console.WriteLine("La multiplicación es: " + resu3);

            Console.WriteLine("La division es: " + div(3, 8));
        }

        /// <summary>
        /// Método que permite sumar dos números
        /// </summary>
        /// <param name="num1">Primer parámetro</param>
        /// <param name="num2">Segundo parámetro</param>
        /// <returns>La suma de dos números</returns>
        static int suma(int num1, int num2) {
            return num1 + num2;
        }

        static int resta(int num1, int num2)
        {
            return num1 - num2;
        }
        static int multi(int num1, int num2)
        {
            return num1 * num2;
        }
        static int div(int num1, int num2)
        {
            return num1 / num2;
        }
        #endregion


    }
}
