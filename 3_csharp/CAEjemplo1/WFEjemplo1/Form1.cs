using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFEjemplo1
{
    public partial class Form1 : Form
    {
        Funciones fnc = new Funciones();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Conversiones";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = fnc.DecABin(int.Parse(txtTexto.Text.ToString()));
        }
    }
}
