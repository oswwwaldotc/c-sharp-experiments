using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_project
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set { _edad = value >= 0 ? value : 0; }
        }
        //Shortcuts "props"

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;

        }

        public Persona()
        {
            //Shortcut "ctor"
        }

        public string Saludas()
        {
            return string.Format("Nombre:{0}   Apellido:{1}", Nombre, Apellido);
        }

        public override string ToString()
        {
            return string.Format("Nombre:{0}   Apellido:{1}    Edad:{2}", Nombre, Apellido, Edad);
        }
    }
}
