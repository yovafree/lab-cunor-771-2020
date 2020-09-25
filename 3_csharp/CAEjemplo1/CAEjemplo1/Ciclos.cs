using System;
using System.Collections.Generic;
using System.Text;

namespace CAEjemplo1
{
    class Ciclos
    {
        static void Main(string[] args)
        {
            /*
             Ciclo For
             */
            //for (int x = 1; x <= 10; x++)
            //{
            //    for (int y = 1; y <= 10; y++)
            //    {
            //        Console.WriteLine(x + " * " + y + " = " + (y * x));
            //    }
            //    Console.WriteLine("------");
            //}

            /*
             Ciclo Do While
             */

            //int m = 9;
            //do
            //{
            //    m++;
            //    Console.Write(m);
            //    int n = 0;
            //    do
            //    {
            //        n++;
            //        Console.Write(n);
            //    } while (n < 10);
            //} while (m < 10);


            /*
                Ciclo While
             */
            int m = 0;
            while (m < 20) {
                m++;
                Console.WriteLine(m);
            }

            Console.ReadKey();
        }
    }
}
