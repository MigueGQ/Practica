using Prac1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1.Negocio
{
    class NClsTienda
    {
        public string CalcularDesc(ClsTienda cons)
        {
            if (cons.Dia == 2 || cons.Dia == 5)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Este dia aplica para un decuento de 15%");
                double resultado = cons.Monto - (cons.Monto * 0.15);
                return "Su total a pagar es de: " + resultado;
            }

            if (cons.Dia == 1 || cons.Dia == 3 || cons.Dia == 4 || cons.Dia == 6 || cons.Dia == 7)
            {
                Console.WriteLine("------------------------");
                return "No aplica ningún descuento, su total a pagar es de: " + cons.Monto;
            }

            else
                Console.WriteLine("------------------------");
                return "Día no válido, favor ingresar uno válido";
        }
    }
}
