using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, resta, multiplicacion, division;
            Console.WriteLine("Debe introducir dos valores");
            int val1 = 0;
            int val2 = 0;
            Console.WriteLine("Introduzca el primer valor");
            val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor");
            val2 = int.Parse(Console.ReadLine());
            suma = val1 + val2;
            resta = val1 - val2;
            multiplicacion = val1 * val2;
            division = val1 / val2;
            Console.WriteLine("La suma de los dos valores es : " + suma);
            Console.WriteLine("La resta de los dos valores es : " + resta);
            Console.WriteLine("La multiplicacion de los dos valores es : " + multiplicacion);
            Console.WriteLine("La division de los dos valores es : " + division);

            Console.ReadKey();

        }
    }
}
