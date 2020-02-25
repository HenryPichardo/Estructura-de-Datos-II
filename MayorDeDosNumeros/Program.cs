using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Introduzca el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("El primer numero es el mayor de los dos : " + num1 + " es mayor que " + num2);

            }
            else if (num1 == num2)
            {
                Console.WriteLine("El primer numero es igual al segundo : " + num1 + " es igual a " + num2);
            }
            else
            {
                Console.WriteLine("El Segundo numero es el mayor de los dos : " + num2 + " es mayor que " + num1);

            }
            Console.ReadKey();
        }
    }
}
