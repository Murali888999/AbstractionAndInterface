using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    interface A
    {
        void add(int a ,int b);
    }
    interface B : A
    {
        void sub(int i, int j);
    }
    class implementcls : B
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            implementcls obj = new implementcls();
            obj.add(12, 34);
            obj.sub(23, 3);
            Console.ReadKey();
        }
    }
}
