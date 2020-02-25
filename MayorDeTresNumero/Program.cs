using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeTresNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("****Este programa determina el mayor de tres numeros****");
            Console.WriteLine("****");
            Console.WriteLine("Por favor introduzca el primer numero y presione la tecla enter...");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("****");
            Console.WriteLine("Por favor introduzca el segundo numero y presione la tecla enter...");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("****");
            Console.WriteLine("Por favor introduzca el tercer numero y presione la tecla enter...");
            num3 = int.Parse(Console.ReadLine());
            if ((num1 > num2) & (num1 > num3))
            {
                Console.WriteLine(" El primer numero es el mayor de los tres...= " + num1);
            }
            else if ((num2 > num1) & (num2 > num3))
            {
                Console.WriteLine(" El segundo numero es el mayor de los tres...= " + num2);
            }
            else 
            {
                Console.WriteLine(" El tercer numero es el mayor de los tres...= " + num3);
            }
            Console.ReadKey();
        }
    } 
}
