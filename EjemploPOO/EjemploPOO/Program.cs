using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona objpersona = new Persona();
            objpersona.nombre = "Henry";
            objpersona.apellido = "Pichardo";
            objpersona.fechaNac = DateTime.Parse("04/03/1979");

            Console.WriteLine(objpersona.ObtenerDatos());
            Console.ReadKey();
        }
    }
}
