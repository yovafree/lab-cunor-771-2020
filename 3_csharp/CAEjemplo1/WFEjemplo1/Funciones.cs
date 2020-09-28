using System;
using System.Collections.Generic;
using System.Text;

namespace WFEjemplo1
{
    class Funciones
    {

        public string DecABin(int n) {
            string str="";

            for (int x = 1; x <= 8; x++) {
                int a = n / 2;
                int b = n % 2;
                n = a;
                str = b + str;
            }

            return str;
        }
    }
}
