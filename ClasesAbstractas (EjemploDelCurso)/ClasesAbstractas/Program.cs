using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    //Ejemplo del curso
    //De momento no he visto mucho uso de "abstract"  en proyecto reales
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoHonorarios eh = new EmpleadoHonorarios("John", "Ventas", 12000);
            eh.Trabajar();
            Console.WriteLine("Salario por honorarios: {0}", eh.Salario);

            EmpleadoNomina en = new EmpleadoNomina("Jane", "RH", 9000);
            en.Trabajar();
            Console.WriteLine("Salario por nómina: {0}", en.Salario);
        }
    }
}
