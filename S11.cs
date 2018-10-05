using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void DelEventHandler();

    class S11
    {
        public static event DelEventHandler add;

        static void USA()
        {
            Console.WriteLine("USA");
        }

        static void India()
        {
            Console.WriteLine("India");
        }

        static void England()
        {
            Console.WriteLine("England");
        }

        static void Main(string[] args)
        {
            add += new DelEventHandler(USA); // so instanced used for calling bcz all are in same class
            add += new DelEventHandler(India);
            add += new DelEventHandler(England);
            add.Invoke();

            Console.ReadLine();
        }
        
    }
}
