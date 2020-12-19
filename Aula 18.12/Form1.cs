using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_18._12
{
    public partial class frmCalculadoraDeRetangulo : Form
    {
        public frmCalculadoraDeRetangulo()
        {
            InitializeComponent();
            lblResultado.Text = "0";
        }

        private void clicar_calcular(object sender, EventArgs e)
        {
            Retangulo rect1 = new Retangulo(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
            rect1.CalcularArea();
            lblResultado.Text = rect1.GetArea().ToString();


        }
    }
}
