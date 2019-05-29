using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class TestClass1
    {
        private int i = 0;

        public void setValue(int value)
        {
            i = value;
        }

        public void getValue()
        {
            Console.WriteLine("Th value of i is " + i);
        }
        public void testcase1(string return1)
        {
            Console.WriteLine("TestCase 1" + return1);
        }

        public void testcase2(string return2)
        {
            Console.WriteLine("TestCase 2" + return2);
        }
    }
}
