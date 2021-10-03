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
    public partial class FrmResta : Form
    {
        public FrmResta()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TxtNum1.Text);
            double num2 = Convert.ToDouble(TxtNum2.Text);

            ClsOperaciones operaciones  = new ClsOperaciones(num1, num2);
            NClsOperaciones nclsoperaciones = new NClsOperaciones();
            TxtR.Text = "La respuesta es: " + nclsoperaciones.Resta(operaciones);
        }
    }
}
