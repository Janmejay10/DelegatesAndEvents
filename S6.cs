using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class S6    // array of delegates
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition={0}", a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication={0}", a * b);
        }
    }

    public delegate void Calc(int x, int y);

    class S7
    {
        static void Main(string[] args)
        {
            Calc[] obj =
            {
                new Calc(S6.Add), new Calc(S6.Mul) // we didn't make objects of S6 bcz their methods are static
            };                                       // and that methods will be called by class name

            for(int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](5, 7);
                obj[i](21, 3);
            }
            Console.Read();
        }
    }
}
