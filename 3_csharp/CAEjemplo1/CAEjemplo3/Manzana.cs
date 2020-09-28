using System;
using System.Collections.Generic;
using System.Text;

namespace CAEjemplo3
{
    class Manzana : Fruta
    {
        public float peso { get; set; }

        public Manzana() {
            this.nombre = "Manzana Verde";
        }

        public Manzana(string nombre) {
            this.nombre = nombre;
        }

        public Manzana(string nombre,string color, string sabor, string forma)
        {
            this.nombre = nombre;
            this.color = color;
            this.sabor = sabor;
            this.forma = forma;
        }

        public override void mostrarInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("NOMBRE: " + this.nombre);
            Console.WriteLine("COLOR: " + this.color);
            Console.WriteLine("SABOR: " + this.sabor);
            Console.WriteLine("FORMA: " + this.forma);
            Console.WriteLine("PESO: " + this.peso);
        }
    }
}
