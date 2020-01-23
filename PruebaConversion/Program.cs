using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad = 5;
            double Precio = 10;
            decimal SubTotal = Convert.ToDecimal(Cantidad) * Convert.ToDecimal(Precio);
            double Descuento = Convert.ToDouble(SubTotal) * 0.05;
            decimal Total = Convert.ToDecimal(SubTotal) - Convert.ToDecimal(Descuento);

            Console.WriteLine("Cantidad = {0}\nPrecio = RD{1:c}\nSubTotal = RD{2:c}\nDescuento = RD{3:c}\nTotal = RD{4:c}", Cantidad,Precio,SubTotal,Descuento,Total);
            Console.ReadKey();
        }
    }
}
