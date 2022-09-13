using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_project
{
    internal class Rectangle
    {
        //Propierties
        public int x_base { get; set; }
        public int y_height { get; set; }

        //Method
        public int CalculateArea(int x_base, int y_height)
        {
            return x_base * y_height;
        }

    }
}
