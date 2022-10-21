using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Si dos clases tienen el mismo nombre pero diferente Namespace es posible usarlas en el mismo proyecto.
namespace accessmodifiers_00
{
    class OneMoreClass
    {
        //OneMoreClass moreClass = new OneMoreClass();
        public void PublicMethod()
        {
            Console.WriteLine("Public Method A01\n");

            //--------------------------------
            //at accessmodifiers_00.OneMoreClass..ctor()
            //--------------------------------
            //at accessmodifiers.Program.Main(System.String[])
            //moreClass.PrivateMethod();
        }

        //Usado en esta clase o cualquier otra que herede
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method B02\n");
            //moreClass.ProtectedMethod();
        }

        //Puede ser visto en cualquier clase del mismo assembly
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method C03");
        }

        //Solo visto desde esta clase
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method D04");
        }
    }
}