using accessmodifiers_00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con diferente namespace
            OneMoreClass one = new();

            one.PublicMethod();
            one.InternalMethod();
        }
    }
}
