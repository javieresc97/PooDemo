using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Grado { get; set; }
        public int Edad { get; set; }
        public string Instituto { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }

        public Alumno(string nombre, string grado, int edad, string instituto, float nota1, float nota2)
        {
            Nombre = nombre;
            Grado = grado;
            Edad = edad;
            Instituto = instituto;
            Nota1 = nota1;
            Nota2 = nota2;
        }

        public float CalcularPromedio(float nota1, float nota2)
        {
            //  Declara una variable
            float promedio;

            //  Calcula promedio
            promedio = (nota1 + nota2) / 2;

            //  Retornar valor 
            return promedio;
        }
    }
}
