using Prac1.Entidades;
using Prac1.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsTienda clstienda = new ClsTienda();
            NClsTienda nclstienda = new NClsTienda();

            Console.WriteLine("Escriba el monto a gastar");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escriba el número del día");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1)Lunes");
            Console.WriteLine("2)Martes");
            Console.WriteLine("3)Miercoles");
            Console.WriteLine("4)Jueves");
            Console.WriteLine("5)Viernes");
            Console.WriteLine("6)Sabado");
            Console.WriteLine("7)Domingo");
            int dia = Convert.ToInt32(Console.ReadLine());

            ClsTienda cons = new ClsTienda(monto, dia);

            Console.WriteLine(nclstienda.CalcularDesc(cons));
            Console.ReadLine();
        }
    }
}
