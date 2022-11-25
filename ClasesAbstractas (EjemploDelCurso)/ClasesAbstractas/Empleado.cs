using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    //Ejemplo del curso
    //De momento no he visto mucho uso de "abstract"  en proyecto reales
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public abstract decimal Salario { get; }

        public Empleado(string nombre, string puesto)
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola mi nombre es: {0}", Nombre);
        }

        public abstract void Trabajar();
    }
}
