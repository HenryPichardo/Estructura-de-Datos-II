using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTablaMultiplicarWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int tabla = 0;
            int producto = 0;

            Console.WriteLine("Digite el numero de la tabla que quiera visualizar: (del 1 al 12)");
            tabla = int.Parse(Console.ReadLine());

            while ( contador <= 12)
            {
                producto = contador * tabla;
                Console.WriteLine(contador + " X " + tabla + " = " + producto);
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
