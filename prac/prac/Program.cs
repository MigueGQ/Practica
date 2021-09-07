using prac.Entidades;
using prac.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsDinero clsdinero = new ClsDinero();
            NClsDinero nclsdinero = new NClsDinero();

            Console.WriteLine("Escriba 1 si quiere sacar dinero ");
            int dato = Convert.ToInt32(Console.ReadLine());

            ClsDinero dinero = new ClsDinero(dato);

            Console.WriteLine(nclsdinero.Ciclo(dinero));
        }
    }
}
