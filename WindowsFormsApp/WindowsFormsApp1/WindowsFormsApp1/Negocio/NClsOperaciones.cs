using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Negocio
{
    class NClsOperaciones
    {
        double r;

        public double Suma(ClsOperaciones operaciones)
        {
            r = operaciones.Num1 + operaciones.Num2;

            return r;
        }

        public double Resta(ClsOperaciones operaciones)
        {
            r = operaciones.Num1 - operaciones.Num2;

            return r;
        }

        public double Multiplicacion(ClsOperaciones operaciones)
        {
            r = operaciones.Num1 * operaciones.Num2;

            return r;
        }

        public double Division(ClsOperaciones operaciones)
        {
            r = operaciones.Num1 / operaciones.Num2;

            return r;
        }
    }
}
