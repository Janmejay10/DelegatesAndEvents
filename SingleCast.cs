using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class SingleCast    // within a class
    {
        static void Display(string s)
        {
            Console.WriteLine("value of s is:" + s);
        }

        public delegate void MyDelegate(string a); // step 1

        static void Main(string[] args)
        {
            MyDelegate obj1 = new MyDelegate(Display);  // step 2
            obj1("hello"); // step3
            Console.Read();
        }
    }
}
