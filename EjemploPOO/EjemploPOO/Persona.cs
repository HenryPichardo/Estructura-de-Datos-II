using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
   public class Persona
    {
        //CAMPO 
        private int _edad;
        //POPIEDADES
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechaNac { get; set; }

        //COMPORTAMIENTO O PROCEDIMIENTOS

            //metodo de procedimiento
        public void CalcularEdad()
        {
            _edad = DateTime.Now.Year - fechaNac.Year;
                 
        }
        public string ObtenerDatos()
        {
            CalcularEdad();
            return string.Format("Sr {0}  {1} nacido el {2} tiene {3} años de edad" ,  apellido, nombre, fechaNac, _edad);
        }

    }
}
