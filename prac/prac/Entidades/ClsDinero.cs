using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Entidades
{
    class ClsDinero
    {
        private int dato;

        public int Dato { get => dato; set => dato = value; }

        public ClsDinero(int dato)
        {
            this.Dato = dato;
        }

        public ClsDinero()
        {
     
        }
    }
}
