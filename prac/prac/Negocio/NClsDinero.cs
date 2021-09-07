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

        public String Ciclo(ClsDinero dinero)
        {

            while (dinero.Dato == 1)
            {

                Console.WriteLine("Coloca un valor a sacar tu dinero");
                int x = Convert.ToInt32(Console.ReadLine());


                if (x % 5 == 0)
                {
                    Console.WriteLine("Puedes sacar tu dinero");

                    Console.WriteLine("Presione 2 si dese cancelar, si desea continuar presione cualquier número");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 2)
                    {
                        dinero.Dato = dinero.Dato + 1;
                    }

                    else
                    {
                        dinero.Dato = dinero.Dato;
                    }
                }
                else
                {

                    Console.WriteLine("Error no puedes sacar tu dinero");

                    Console.WriteLine("Presione 2 si dese cancelar, si desea continuar presione cualquier número");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 2)
                    {
                        dinero.Dato = dinero.Dato + 1;
                    }

                    else
                    {
                        dinero.Dato = dinero.Dato;
                    }
                }

            }
            return "";
        }

    }
}
