namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizados con pocas propiedades y con datos predefinidos
            
            Vector vector1 = new Vector(1,2,3);
            Vector vector2 = new Vector(4,5,6);

            Console.WriteLine("Vector 01 {0}", vector1.CalcularModulo());
            Console.WriteLine("Vector 02 {0}", vector2.CalcularModulo());

            Vector vector3 = vector1.Suma(vector2);
            Console.WriteLine(vector1);
            Console.WriteLine(vector2);
            Console.WriteLine(vector3);

            ComplexNumbers complex01 = new ComplexNumbers(3,4);
            ComplexNumbers complex02 = new ComplexNumbers(-0.5,2);
            ComplexNumbers resultado = complex01.ComplexSum(complex02);
            Console.WriteLine(resultado);


            ComplexNumbers complex03 = new ComplexNumbers(1, 2);
            ComplexNumbers complex04 = new ComplexNumbers(3, 4);
            ComplexNumbers resultado02 = complex03.ComplexSum(complex04);
            Console.WriteLine(resultado02);

            //Las clases son tipos de referencia
            //Una entidad simple (con pocas propiedades string, int, double y que no necesita herencia) es recomendable representarla como una estructura.
            //Las estructuras no pueden definir un constructor vacío, el compilador se encarga de generar uno y no lo podemos modificar.
        }
    }
}