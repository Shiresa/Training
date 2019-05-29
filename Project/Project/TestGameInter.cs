using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TestGameInter : IGames
    {

        public void add()
        {
            Console.WriteLine(5 + 5);
        }

        public void subtract()
        {
            Console.WriteLine(10 - 5);
        }

        public void test()
        {
            throw new NotImplementedException();
        }

        public string test1()
        {
            throw new NotImplementedException();
        }
    }
}
