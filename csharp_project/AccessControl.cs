using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_space_01
{
    class Class_01
    {
        public void Metodo()
        {
            Console.WriteLine(" -> extra_space_01");
        }
    }
}

namespace Extra_space_02
{
    class Class_01
    {
        public void Metodo()
        {
            Console.WriteLine(" -> extra_space_02\n");
        }
    }
}

namespace csharp_project
{
    internal class AccessControl
    {
        //Solo deben ser accesibles a traves de las propiedades y metodos designados

        // 01:private, 02:protected, 03:internal, 04:public
        
       public void ExtraNameSpaces()
        {
            //New object from different namespaces
            Extra_space_01.Class_01 _01 = new Extra_space_01.Class_01();

            _01.Metodo();
           
            //Fully Qualified Name 
            Extra_space_02.Class_01 _02 = new Extra_space_02.Class_01();

            _02.Metodo();

        }
    }
}
