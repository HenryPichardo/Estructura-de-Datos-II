using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEnumeraciones
{
    class Program
    {
        public enum Meses  {
        enero = 1,
        febrero,
        marzo,
        abril,
        mayo,
        junio,
        julio,
        agosto,
        septiembre,
        octubre,
        noviembre,
        diciembre}
        static void Main(string[] args)
        {
            Meses ocho = (Meses)8;
            Meses uno = (Meses)1;
            Console.WriteLine(ocho);
            Console.WriteLine(uno);
            Console.ReadKey();
        }
    }
}
