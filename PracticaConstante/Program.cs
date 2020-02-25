using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaConstante
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad = 5;
            double Precio = 10;
            const double porcImpuesto = 0.18;
             
            double subTotal = (Cantidad * Precio);
            double valorImpuesto = subTotal * porcImpuesto;
            double total = subTotal + valorImpuesto;

            Console.WriteLine("Cantidad ={0}\nPrecio = {1}\nImpuestos = {2}\nSubTotal = {3}\nTotal = {4}" ,Cantidad, Precio, valorImpuesto, subTotal, total);

            Console.ReadKey();

        }
    }
}
