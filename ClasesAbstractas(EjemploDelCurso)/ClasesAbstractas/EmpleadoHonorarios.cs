using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    //Ejemplo del curso
    //De momento no he visto mucho uso de "abstract"  en proyecto reales
    class EmpleadoHonorarios : Empleado
    {
        public decimal SueldoBase { get; set; }

        public override decimal Salario
        {
            get
            {
                return SueldoBase * 0.84m;
            }
        }

        public EmpleadoHonorarios(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por honorarios...");
        }
    }
}
