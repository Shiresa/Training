using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TestClass1 Test1 = new TestClass1();

            Test1.setValue(55);
            Test1.getValue();

            Console.ReadLine();
        }
    }
}
