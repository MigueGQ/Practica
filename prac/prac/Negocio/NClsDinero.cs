using prac.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Negocio
{
    class NClsDinero
    {

        public String Ciclo()
        {
            int dato = 1;
            ClsDinero ObjDinero = new ClsDinero();

            while (dato == 1)
            {

                Console.WriteLine("Coloca un valor a sacar tu dinero");
                ObjDinero.Dinero = Convert.ToInt32(Console.ReadLine());


                if (ObjDinero.Dinero % 5 == 0)
                {
                    Console.WriteLine("Puedes sacar tu dinero");
                }
                else
                {

                    Console.WriteLine("Error no puedes sacar tu dinero");
                    Console.ReadLine();
                    dato = 2;
                }

            }
            return "";
        }

    }
}
