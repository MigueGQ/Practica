using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2.Entidades
{
    class ClsTemperatura
    {
        private double tp;

        public double Tp { get => tp; set => tp = value; }


        public ClsTemperatura(double tp)
        {
            this.Tp = tp;
        }

        public ClsTemperatura()
        {
        }
    }
}
