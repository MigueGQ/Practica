using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vistas
{
    public partial class FrmMenuApp : Form
    {
        public FrmMenuApp()
        {
            InitializeComponent();
        }

        private void FrmMenuApp_Load(object sender, EventArgs e)
        {

        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        FrmSuma suma = new FrmSuma();
        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suma.MdiParent = this;
            suma.Show();
        }

        FrmResta resta = new FrmResta();
        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resta.MdiParent = this;
            resta.Show();
        }

        FrmMultiplicacion multiplicacion = new FrmMultiplicacion(); 
        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiplicacion.MdiParent = this;
            multiplicacion.Show();
        }

        FrmDivision division = new FrmDivision();
        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            division.MdiParent = this;
            division.Show();
        }
    }
}
