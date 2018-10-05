using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class S1                    // within a class
    {
        static void Add(int a, int b)
        {
            int c = a + b;

            Console.WriteLine("value of addition is:" + c);
        }

        public delegate void MyDelegate(int x,int y); // step 1

        static void Main(string[] args)
        {
            MyDelegate obj1 = new MyDelegate(Add);  // step 2 we could have written S1.Add also no issue
                    // bcz Add is static member can be called directly by static of other class

            obj1(10,20); // step3 we could have written obj1.Invoke(10,20) also 

            
            Console.Read();
        }
    }
}
