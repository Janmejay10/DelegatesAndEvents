using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class S2      //singleCast from another class
    {
        public void Add(int a, int b)
        {
            int c = a + b;

            Console.WriteLine("value of addition is:" + c);
        }
    }

    public delegate void MyDelegat2(int x, int y);
    class S3
    {
        static void Main(string[] args)
        {
            S2 obj1 = new S2();
            MyDelegat2 obj2 = new MyDelegat2(obj1.Add);// because add function is in S2 class
            obj2(10,20);                              // n calling by S2 class object
            Console.Read();
        }                                               

    }

}
