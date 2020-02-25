using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscribeNombreDelDia
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("Esta aplicacion escribe el nombre de los dias de la semana");
            Console.WriteLine("");
            Console.WriteLine("Por favor escriba el numero del dia de la semana (del 1 al 7) y luego Presione la tecla enter");
            dia = int.Parse(Console.ReadLine());
            if (dia == 1)
            {
                Console.WriteLine("Lunes");
            }
            else if (dia == 2)
            {
                Console.WriteLine("Martes");
            }
            else if (dia == 3)
            {
                Console.WriteLine("Miercole");
            }
            else if (dia == 4)
            {
                Console.WriteLine("Jueves");
            }
            else if (dia == 5)
            {
                Console.WriteLine("Viernes");
            }
            else if (dia == 6)
            {
                Console.WriteLine("Sabado");
            }
            else if (dia == 7)
            {
                Console.WriteLine("Domingo");
            }
            else
            {
                Console.WriteLine("Numero del dia incorrecto");
            }

            Console.ReadKey();
        }
    }
}
