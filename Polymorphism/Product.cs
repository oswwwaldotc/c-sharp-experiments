using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /*
     * Los simbolos de < > son llamados Generics
     * Generics allow you to define the specification of the data type 
     * of programming elements in a class or a method, until it is 
     * actually used in the program. 
     * 
     * In other words, generics allow you to write a class 
     * or method that can work with any data type.
     */

    internal class Product : IComparable<Product>
    {
        public string Code { get; set; }
        public decimal Price { get; set; }

        //Agregamos una nueva funcionalidad (override) para validar entre productos
        public int CompareTo(Product? other)
        {
            // > 0 Es mayor | == 0 Es igual | < 0 Es menor
            //throw new NotImplementedException();
            if (this.Price > other.Price) return 1;
            //if (this.Price < other.Price) return -1;
            if (this.Price == other.Price) return 0;

            return -1;
        }
    }
}
