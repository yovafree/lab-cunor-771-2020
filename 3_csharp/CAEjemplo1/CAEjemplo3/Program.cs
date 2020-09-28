using System;

namespace CAEjemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruta manzana = new Fruta();
            manzana.nombre = "Manzana";
            manzana.color = "Roja";
            manzana.sabor = "Dulce";
            manzana.forma = "Semi circular";

            manzana.mostrarInfo();

            Manzana manzana1 = new Manzana("Manzana Verde Ácida", "Verde","Ácido","Semi circular");
            manzana1.peso = 0.20F;

            manzana1.mostrarInfo();

            Console.ReadKey();

        }
    }
}
