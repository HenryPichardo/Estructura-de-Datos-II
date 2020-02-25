using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz2Dimenciones
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[,] ventas = new string[3,4];
            for (int fila=0;fila < 3;fila++)
            {
                Console.WriteLine("Introduzca el Producto:" + (fila +1));
                ventas[fila, 0] = Console.ReadLine();
                Console.WriteLine("Introduzca la cantidad:");
                ventas[fila, 1] = Console.ReadLine();
                Console.WriteLine("Introduzca el Precio");
                ventas[fila, 2] = Console.ReadLine();
                double cantidad = Convert.ToDouble(ventas[fila, 1]);
                double precio = Convert.ToDouble(ventas[fila, 2]);
                double total = Convert.ToDouble(ventas[fila, 1]) * Convert.ToDouble(ventas[fila, 2]);
                ventas[fila, 3] = Convert.ToString(total);

            }
            Console.WriteLine("LISTA DE PRODUCTOS");
            for (int fila = 0; fila < 3; fila++) 
            {
                Console.WriteLine("Productos : {0}\t Cantidad : {1}\t Precio : {2}\t Total : {3}", ventas[fila,0], ventas[fila,1],ventas[fila,2],ventas[fila,3]);
            }
            Console.ReadKey();
        }
    }
}
