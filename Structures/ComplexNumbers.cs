using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct ComplexNumbers
    {
        public double Real { get; }
        public double Imaginario { get; }

        
        public ComplexNumbers(double real, double imaginario) : this()
        {
            Real = real;
            Imaginario = imaginario;
        }

        public ComplexNumbers ComplexMultiply(ComplexNumbers other)
        {
            return new ComplexNumbers(Real * other.Real- Imaginario * other.Imaginario, Real * other.Imaginario + Imaginario * other.Real);
        }

        public ComplexNumbers ComplexSum(ComplexNumbers other)
        {
            return new ComplexNumbers(Real + other.Real, Imaginario + other.Imaginario);
        }

        public override string ToString()
        {
            return String.Format("Complex Number Re[{0:0.0}-{1:0.0}]i", Real, Imaginario);
        }
    }
}
