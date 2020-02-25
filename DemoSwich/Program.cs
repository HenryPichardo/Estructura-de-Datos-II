using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwich
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;
            Console.WriteLine("Introduzca la nota del 1 al 5");
            nota = Convert.ToInt32(Console.ReadLine());
            switch (nota) {
                case 1:
                    Console.WriteLine("SOBRESALIENTE");
                    break;
                case 2:
                    Console.WriteLine("BUENA");
                    break;
                case 3:
                    Console.WriteLine("ACEPTABLE");
                    break;
                case 4:
                    Console.WriteLine("COMPLETIVO");
                    break;
                case 5:
                    Console.WriteLine("INSUFICIENTE");
                    break;
                default:
                    Console.WriteLine("Nota incorrecta, debe introducir un numero comprendido entre 1 y 5");
                    break;
            }
            Console.ReadKey();
        }
    }
}
