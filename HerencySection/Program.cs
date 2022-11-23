using HerencySection;

namespace HerencySpace
{
    class Program
    {
        //Herencia
        // Superclases y Subclases
        // Solo se puede heredar de una y solo una clase
        // Para aplicar temas mas complejos es posible usarlo con Interfaces

        //?Cuando es necesario aplicar herencia?
        //Relacion IS-A (Object A is a Object B?)
        static void Main(string[] args)
        {
            Person person01 = new("Beto", 23);
            person01.SayHello();
            person01.ToString();
            Console.WriteLine(" \n " + person01);

            Console.WriteLine();
            Employee person02 = new("Carlos", 78, "Sales person", 20050);
            person02.SayHello();
            person02.ToString();
            person02.Working();
            Console.WriteLine(" \n " + person02);

            Console.WriteLine();
            Student person03 = new("Gerardo", 15, 7.8, "Highschool");
            person03.SayHello();
            person03.ToString();
            person03.Study();
            person03.GoToSchool();
            Console.WriteLine(" \n " + person03);
        }
        /* La definición de un método abstracto termina en punto y coma (;)
           por lo que no es posible agregar código dentro de él.
           Todas las clases en C# heredan directa o indirectamente de la clase Object
        */
    }
}
