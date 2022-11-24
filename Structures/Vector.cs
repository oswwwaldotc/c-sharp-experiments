using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct Vector
    {
        //Struct no puede definir un constructor vacio mas debe llamarlo con "this"
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //Inmutabilidad :: Principle
        public Vector(double x, double y, double z) : this()
        {
            //Propiedad first then value/object
            X = x;
            Y = y;  
            Z = z;  
        }

        public double CalcularModulo()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z,2));  
        }

        public Vector Suma(Vector other)
        {
           return new Vector(X + other.X, Y + other.Y, Z + other.Z);   
        }

        public override string ToString()
        {
            return String.Format("[{0},{1},{2}]",X,Y,Z);
        }
    }
}
