using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTablaMultiplicarFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla, producto, acumulador = 0;
            Console.WriteLine("Introduzca el numero de la tabla de multiplicar que desea visualizar");
            tabla = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= 12; contador++)
            {
                producto = tabla * contador;
                acumulador = acumulador + producto;
                Console.WriteLine(tabla + " X " + contador + " = " + producto);
                
                

            }
            Console.WriteLine("El total de producto acumulado (sumatoria) es : " + acumulador);
            Console.ReadKey();


            
        }
    }
}
