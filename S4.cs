using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class S4             //MultipleCast
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("the Addition is:" + (a + b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("the Subtraction is:" + (a - b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("the Multiplication is:" + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("the Division is:" + (a / b));
        }
    }

    public delegate void MultiCast1(int a, int b);// variables could be x and y also no issue

    class S5
    {
        static void Main(string[] args)
        {
            S4 obj1 = new S4();
            MultiCast1 obj2 = new MultiCast1(obj1.Add); // here we are passing method name as parameter

            // now to add functions from delegate object for operations with same object

            obj2 += obj1.Sub;
            obj2 += obj1.Mul;
            obj2 += obj1.Div;

            obj2(10, 20);

            // now to remove functions from delegate object for operations with same object

            obj2 -= obj1.Mul;
            obj2 -= obj1.Div;

            obj2(30, 60);

            Console.Read();
        }
    }
}
