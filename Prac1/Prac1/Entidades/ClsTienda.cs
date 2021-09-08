using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1.Entidades
{
    class ClsTienda
    {
        private double monto;
        private int dia;

        public double Monto { get => monto; set => monto = value; }
        public int Dia { get => dia; set => dia = value; }

        public ClsTienda(double monto, int dia)
        {
            this.monto = monto;
            this.dia = dia;
        }

        public ClsTienda()
        {

        }

    }
}
