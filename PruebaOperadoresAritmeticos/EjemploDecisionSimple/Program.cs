using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDecisionSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un Valor");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 100)
                Console.WriteLine("el numero {0} es mayor que 100", numero);
            Console.ReadKey();
        }
    }
}
