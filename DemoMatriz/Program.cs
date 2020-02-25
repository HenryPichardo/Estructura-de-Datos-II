using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("****SISTEMA DE FACTURACION DE PRODUCTOS*******");          
            Console.WriteLine("****   Cuantos Productos se van a facturar?   *******");
            int cantProductos = int.Parse(Console.ReadLine());           
            string[,] ventas = new string[cantProductos , 4];
            int contador = 0;
            for (int i = 0; i < cantProductos; i++)
            {
                Console.WriteLine("Escriba el Nombre del producto #" + (i + 1));
                ventas[i, 0] = Console.ReadLine();

                Console.WriteLine("Introduzca la Cantidad:");
                ventas[i, 1] = Console.ReadLine();

                Console.WriteLine("Introduzca el Precio:");
                ventas[i, 2] = Console.ReadLine();

                Console.WriteLine("*******     Elija una opcion y luego presione la tleca enter");
                Console.WriteLine(" ");
                Console.WriteLine("******* Continuar presione la tecla(c)");
                Console.WriteLine(" ");
                Console.WriteLine("******* Terminar presione la tecla(t)");
                string opcion = Console.ReadLine();
                if (opcion == "c")
                {
                }
                else if (opcion == "t")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" Elija una opcion valida");
                }
                contador++;
            }            
            double subTotal;
            double total = 0;
            for (int i = 0; i < cantProductos; i++)
            {
                int cantidad = Convert.ToInt32(ventas[i, 1]);
                double precio = Convert.ToDouble(ventas[i, 2]);               
                subTotal = cantidad * precio;
                total = total + subTotal;              
                ventas[i, 3] = Convert.ToString(subTotal);
                contador++;
            }            
            int prodFacturados = 0;          
            for (int i = 0; i < cantProductos; i++) {
                prodFacturados += Convert.ToInt32(ventas[i, 1]);               
                Console.WriteLine("Producto: {0} Cantidad: {1} Precio: {2}  subtotal: {3} ",
                ventas[i, 0],
                ventas[i, 1],
                ventas[i, 2],
                ventas[i, 3]);
                contador++;
                Console.WriteLine("");
            }
            Console.WriteLine("Total de productos facturados = " + prodFacturados);
            Console.WriteLine("Total General = RD$" + total);
            Console.ReadKey();
        }
    
    }
}
