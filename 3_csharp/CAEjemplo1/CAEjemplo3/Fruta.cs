using System;
using System.Collections.Generic;
using System.Text;

namespace CAEjemplo3
{
    class Fruta
    {
        public string nombre { get; set; }
        public string color { get; set; }
        public string sabor { get; set; }
        public string forma { get; set; }

        /// <summary>
        /// Método que muestra la información del objeto fruta
        /// </summary>
        public virtual void mostrarInfo() {
            Console.WriteLine("");
            Console.WriteLine("Nombre " + this.nombre);
            Console.WriteLine("Color " + this.color);
            Console.WriteLine("Sabor " + this.sabor);
            Console.WriteLine("Forma " + this.forma);
        }

        /// <summary>
        /// Método que muestra la información del objeto fruta según el tipo que se desea.
        /// </summary>
        /// <param name="tipo">Muestra la información según el tipo</param>
        public void mostrarInfo(int tipo)
        {
            Console.WriteLine("");
            if (tipo == 0 || tipo == 1) {
                Console.WriteLine("Nombre " + this.nombre);
            }

            if (tipo == 1) {
                Console.WriteLine("Color " + this.color);
                Console.WriteLine("Sabor " + this.sabor);
                Console.WriteLine("Forma " + this.forma);
            }
        }
    }
}
