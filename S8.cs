using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class S8            // making an anoymous method with delegate keyword and nameless func.body
    {
         
        delegate void operation();  // Delegate Definition 

        static void Main(string[] args)
        {
             
            operation obj = delegate  // Delegate instantiation 
            {
                Console.WriteLine("Anonymous method");
            };
            obj();

            Console.Read();
        }
    }
}
