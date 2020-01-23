using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCalculo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "Henry Fernando";
            string Apellido = "Pichardo Gonzalez";
            DateTime FechaNacimiento= DateTime.Parse("04/03/1979");
            string Cedula = "00113018030";
            string Direccion = "C/ 4ta #116 Barrio Nuevo, Vicente Noble Barahona";
            string Telefono = "809-527-2024";
            string Email = "henryfpichardog@gmail.com";
            string Sexo = "Masculino";
            Console.WriteLine("Mi nombre es: {0} {1}\nmi fecha de nacimiento es: {2:D}\nmi cedula es: {3}\nmi direccion es: {4}\ntelefono: {5}\nemail: {6}\nsexo: {7}", Nombre,Apellido,FechaNacimiento, Cedula,Direccion, Telefono,Email,Sexo);
            Console.ReadKey();




        }
    }
}
