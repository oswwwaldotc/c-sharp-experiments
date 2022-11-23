using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle : IFigure
    {
        public int Base { get; set; }
        public int Height { get; set; }


        public double CalcularArea()
        {
            Console.WriteLine("\n Polymorphism Rectangle {0} ", nameof(CalcularArea));
            return Height * Base;
        }

        public void InfoRectangle()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(InfoRectangle));
            Console.WriteLine("⏹ Base {0} Height {1}", Base, Height);
        }
    }
}
