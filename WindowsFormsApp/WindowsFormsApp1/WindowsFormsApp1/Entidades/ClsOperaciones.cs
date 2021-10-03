using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class ClsOperaciones
    {
        private double num1;
        private double num2;

        public ClsOperaciones()
        {
        }

        public ClsOperaciones(double num1, double num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

    }
}
