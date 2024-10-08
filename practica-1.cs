using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica-1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Mirtha", 27," soliz", "12345678 CBA"  );
            Estudiante e1 = new Estudiante();
            Docente d1 = new Docente();
            Administrativo a1 = new Administrativo();

           p1.MostrarInformacion();
           e1.MostrarInformacion();
           d1.MostrarInformacion();
           a1.MostrarInformacion();
           
        }
    }
}