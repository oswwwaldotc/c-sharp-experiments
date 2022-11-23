using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerencySection
{
    internal class Student : Person
    {
        public double AverageStudent { get; set; }
        public string GradeStudent { get; set; }


        public Student(string name, int age, double averagestudent, string gradestudent) : base(name, age)
        {
            AverageStudent = averagestudent;
            GradeStudent = gradestudent;    
        }

        public void Study()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(Study));
            Console.WriteLine(" {0} Focus mode :: ON", Name);
        }

        public void GoToSchool()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(GoToSchool));
            Console.WriteLine(" {0} Go to School", Name);
        }

        public override void SayHello()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(SayHello));
            Console.WriteLine(" Hola. I'm {0} and my grade level is {1}", Name, GradeStudent);
        }

        public override string ToString()
        {
            Console.WriteLine("\nI'm here inside of {0}", nameof(ToString));
            return string.Format("{0} & {1} years old. \n Additonal information: {2} lvl - {3} (calif)", Name, Age, GradeStudent, AverageStudent);
        }
    }
}
