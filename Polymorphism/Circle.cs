using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle : IFigure
    {
        public int Radious { get; set; }

        public double CalcularArea()
        {
            Console.WriteLine("\n Polymorphism Circle {0} ", nameof(CalcularArea));
            return Math.PI * Radious * Radious;
        }

        public void InfoCircule()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(InfoCircule));
            Console.WriteLine("⏺ Radious {0}",Radious);
        }
    }
}
