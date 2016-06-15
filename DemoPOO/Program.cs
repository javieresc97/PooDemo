using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Franchis", 
                "Quinto", 
                18, 
                "I.E. Los cheritos", 
                5, 
                2);
            float promedio = 
                a1.CalcularPromedio(a1.Nota1, a1.Nota2);
            Console.WriteLine(a1.Nombre + " es de " + a1.Instituto);
            Console.WriteLine($"{a1.Nombre} es de {a1.Instituto}");
            Console.WriteLine("{0} es de {1}", 
                a1.Nombre, 
                a1.Instituto);
            Console.Read();
        }
    }
}
