using Polymorphism;

namespace polymorphism
{
    internal class Program
    {
        /*
         * Concepto que se refiere a la habilidad de poder realizar una
         * operacion con objetos de distintos tipos
         * 
         * Beneficios
         * Permite crear sistemas escalables 
         * Objetos distintos tipos se comportan como uno solo.
         */

        static void Main(string[] args)
        {
            /*
             * Utilizando "Interface" is a "contract"
             * Una clase que implementa una interfaz debe 
             * sobrescribir todos sus metodos y propiedades.
             * 
             * Upcasting - Downcasting
             */

            //Upcasting - X IS A Y
            IFigure figue01 = new Circle { Radious = 5 };
            IFigure figue02 = new Circle { Radious = 9 };
            IFigure figure03 = new Rectangle { Base = 4, Height = 3 };
            IFigure figure04 = new Triangle { Height = 10, Base = 8 };

            IFigure[] figures = new IFigure[] { figue01, figue02, figure03, figure04 };
            foreach (var figura in figures)
            {
                Console.WriteLine(figura.CalcularArea());
            }

            //Downcasting AS
            Circle? circle01 = figue01 as Circle;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            circle01.InfoCircule();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Circle? circle02 = figue02 as Circle;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            circle02.InfoCircule();
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Console.WriteLine("\n Estamos comparando los productos");
            Product product01 = new Product { Code = "A1", Price = 123 };
            Product product02 = new Product { Code = "A2", Price = 34.5m };
            Product product03 = new Product { Code = "A3", Price = 99.9m };

            Product[] products = new Product[] { product01, product02, product03 };
            
            //Aqui hacemos uso de la interfaz moficado, el esperado es tenerlos en orden
            Array.Sort(products);
            foreach (var item in products)
            {
                Console.WriteLine("Code {0} Price {1}", item.Code, item.Price);
            }
            //En una interfaz todos los métodos son abstractos
        }
    }
}