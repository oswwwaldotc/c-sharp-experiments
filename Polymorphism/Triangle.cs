using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Triangle : IFigure
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public double CalcularArea()
        {
            Console.WriteLine("\n Polymorphism Triangle {0} ", nameof(CalcularArea));
            return (Base * Height)/2;
        }

        public void InfoTriangle()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(InfoTriangle));
            Console.WriteLine("⚠ Base {0} Height {1}", Base, Height);
        }
    }
}
