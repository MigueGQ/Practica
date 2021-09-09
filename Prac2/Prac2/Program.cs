using Prac2.Entidades;
using Prac2.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2
{
    class Program
    {
        static void Main(string[] args)
        {
            NClsTemperatura nclstemperatura = new NClsTemperatura();

            Console.WriteLine("Escriba la temperatura");
            double tp = Convert.ToDouble(Console.ReadLine());

            ClsTemperatura TempCons = new ClsTemperatura(tp);

            Console.WriteLine(nclstemperatura.Clima(TempCons));
            Console.ReadLine();
        }
    }
}
