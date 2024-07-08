using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {

        public TypeB()
        {
            TypeA obj = new TypeA();

            //obj.x = 10; invalid due to it's protection level [X is private]

            //obj.y = 5;  valid due to it's protection level [X is internal]

            //obj.z = 15; valid due to it's protection level [X is public]





        }

    }
}
