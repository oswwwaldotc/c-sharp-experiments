using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposReferenciaVsTiposValor
{
    class Program
    {
        /*
         Tema core en C#
            Docs
            1. https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type
            2. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
        */

        static void Main(string[] args)
        {
            // Tipo de valor
            Console.WriteLine("Tipos de valor");
            PuntoVal puntoV = new PuntoVal(5, 10);
            PuntoVal otroPunto = puntoV;

            otroPunto.X = 100;
            otroPunto.Y = 60;
            Console.WriteLine("punto: ({0}, {1})", puntoV.X, puntoV.Y);
            Console.WriteLine("otroPunto: ({0}, {1})", otroPunto.X, otroPunto.Y);

            // Tipos de referencia
            Console.WriteLine("Tipos de referencia");
            PuntoRef puntoR = new PuntoRef(5, 10);
            PuntoRef segundoPunto = puntoR;

            segundoPunto.X = 200;
            segundoPunto.Y = 300;
            Console.WriteLine("punto: ({0}, {1})", puntoR.X, puntoR.Y);
            Console.WriteLine("segundoPunto: ({0}, {1})", segundoPunto.X, segundoPunto.Y);
        }
    }
}
