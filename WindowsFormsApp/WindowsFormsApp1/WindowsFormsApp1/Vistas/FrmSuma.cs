using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Vistas
{
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void FrmSuma_Load(object sender, EventArgs e)
        {

        }

        private void Calc_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TxtNum1.Text);
            double num2 = Convert.ToDouble(TxtNum2.Text);

            ClsOperaciones operaciones = new ClsOperaciones(num1, num2);
            NClsOperaciones nclsoperaciones = new NClsOperaciones();
            TxtR.Text = "La respuesta es: " + nclsoperaciones.Suma(operaciones);
        }

        private void TxtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
