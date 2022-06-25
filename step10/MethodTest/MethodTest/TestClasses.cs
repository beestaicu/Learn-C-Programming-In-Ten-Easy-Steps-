using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTest
{
    class A
    {
        public String method1()
        {
            return "Class A: method1\r\n";
        }

        public virtual String method2()
        {
            return "Class A: (virtual) method2\r\n";
        }

        public String method3()
        {
            return "class A: method3\r\n";
        }
    }

    class B : A
    {
        public new String method1() // note 'new' keyword
        {
            return "Class B: (new) method1\r\n";
        }
        public override String method2()
        {
            return "class B: (override) method2\r\n";
        }
        public String method3()
        {
            return "Class B: method3\r\n";
        }

    }
}