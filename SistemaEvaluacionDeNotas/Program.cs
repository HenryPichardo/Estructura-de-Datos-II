using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEvaluacionDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una nota (del 1 al 5)");
            int nota;
            nota = int.Parse(Console.ReadLine());
            if (nota == 1)
            {
                Console.WriteLine("Sobresaliente");
            }
            else if(nota == 2)
            {
                Console.WriteLine("Buena");
            }
            else if (nota == 3)
            {
                Console.WriteLine("Aceptable");
            }
            else if (nota == 4)
            {
                Console.WriteLine("Completivo");
            }
            else if (nota == 5)
            {
                Console.WriteLine("Insuficiente");
            }
            else
            {
                Console.WriteLine("Calificacion incorreta");
            }
            Console.ReadKey();
        }
    }
}
