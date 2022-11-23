using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerencySection
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Sobre escritura (override) es diferente en C#
        //Da a entender que se trata de la superclase (virtual)
        public virtual void SayHello()
        {
            Console.WriteLine(" Hey, hello friend my name is {0}", Name);
        }

        //Da a entender que se trata de la subclase (override)
        public override string ToString()
        {
            return string.Format("{0} & {1} years old ", Name, Age);
        }
    }
}
