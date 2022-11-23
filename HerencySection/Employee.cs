using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerencySection
{
    //Usando Herencia
    internal class Employee : Person
    {
        public string Level { get; set; }
        public decimal Salary { get; set; }

        //base : Significa usando un constructor de la clase padre
        // Se llena primero [name,age] luego la subclase [level,salary]
        public Employee(string name, int age, string level, decimal salary) : base(name, age)
        {
            Level = level;
            Salary = salary;
        }

        public override void SayHello()
        {
            //Default (avoid this)
            // base.SayHello();
            Console.WriteLine(" Hello. I'm {0} and my career level is {1}",Name,Level);
        }

        public void Working()
        {
            Console.WriteLine(" {0} is working, please expected a delay response", Name);
        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0} & {1} year old. \nAdditonal information: {2} lvl - {3} USD", Name, Age, Level, Salary);
        }
    }
}
