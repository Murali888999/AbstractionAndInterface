using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    class MultipleInheritance : D,E
    {
        void D.pass()
        {
            Console.WriteLine("interface D pass() method.implemented ");
        }
        void E.pass()
        {
            Console.WriteLine("interface E pass() method.implemented ");
        }
        public void test()
        {
            Console.WriteLine("test");
        }

        static void Main(string[] args)
        {
            MultipleInheritance obj = new MultipleInheritance();
            obj.test();
            D obj1 = obj;
            E obj2 = obj;
            obj1.pass();
            obj2.pass();
            Console.ReadKey();
        }
    }
    interface D
    {
        void test();
        void pass();
    }
    interface E
    {
        void test();
        void pass();
    }
}
