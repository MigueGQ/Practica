using Prac2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2.Negocio
{
    class NClsTemperatura
    {
        public string Clima(ClsTemperatura TempCons)
        {
            if (TempCons.Tp <= 10)
            {
                return "Está frío";
            }
                
            if (TempCons.Tp > 10 || TempCons.Tp <= 20)
            {
                return "Está nublado";
            }

            if (TempCons.Tp > 20 || TempCons.Tp <= 30)
            {
                return "Caluroso";
            }

            if (TempCons.Tp > 30)
            {
                return "Tropical";
            }    
                return "";
        }
    }
}
