using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hola_mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Mirtha", 27," soliz", "12345678 CBA"  );
           p1.MostrarInformacion();
           
        }
    }
}