using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoComisionVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido;
            
            double montoVentas;
            int añosServ;
            double comision;
            int edad;
            double bonificacion;
            double total;

            Console.WriteLine("Esta app calcula comision por ventas");
            Console.WriteLine("************************************");
            Console.WriteLine("Introduzca el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca el apellido del empleado");
            apellido = Console.ReadLine();
            Console.WriteLine("Introduzca el año de nacimiento del empleado");
            edad = 2020 - int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el monto total de las ventas del empleado");
            montoVentas = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca los años de servicio del empleado");
            añosServ = int.Parse(Console.ReadLine());
            

            if (montoVentas >= 1000 & montoVentas <= 5000)
            {
                comision = montoVentas * 0.05;
                if (edad > 60 | añosServ > 20)
                { 
                    bonificacion = montoVentas * 0.03;
                }
                else
                {
                    bonificacion = 0;
                }
                Console.WriteLine("El empleado gano una comision de : " + comision);
                Console.WriteLine("Bonificacion adicional : " + bonificacion);
                total = bonificacion + comision;
                Console.WriteLine("Total : " + total);
            }
            else if (montoVentas >= 5001 & montoVentas <= 10000)
            {
                comision = montoVentas * 0.10;
                if (edad > 60 | añosServ > 20)
                {
                    bonificacion = montoVentas * 0.03;
                }
                else
                {
                    bonificacion = 0;
                }
                Console.WriteLine("El empleado gano una comision de : " + comision);
                Console.WriteLine("Bonificacion adicional : " + bonificacion);
                total = bonificacion + comision;
                Console.WriteLine("Total : " + total);
            }
            else if (montoVentas >= 10001 & montoVentas <= 50000)
            {
                comision = montoVentas * 0.15;
                if (edad > 60 | añosServ > 20)
                {
                    bonificacion = montoVentas * 0.03;
                }
                else
                {
                    bonificacion = 0;
                }
                Console.WriteLine("El empleado gano una comision de : " + comision);
                Console.WriteLine("Bonificacion adicional : " + bonificacion);
                total = bonificacion + comision;
                Console.WriteLine("Total : " + total);
            }
            else if (montoVentas > 50000)
            {
                comision = montoVentas * 0.20;
                if (edad > 60 | añosServ > 20)
                {
                    bonificacion = montoVentas * 0.03;
                }
                else
                {
                    bonificacion = 0;
                }
                Console.WriteLine("El empleado gano una comision de : " + comision);
                Console.WriteLine("Bonificacion adicional : " + bonificacion);
                total = bonificacion + comision;
                Console.WriteLine("Total : " + total);
            }
            else if (montoVentas < 1000)
            {
                Console.WriteLine("El empleado no tiene comision");
            }

            Console.ReadKey();
        }
    }
}
