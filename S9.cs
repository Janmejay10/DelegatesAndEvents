using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegatesAndEvents
{
    
        class S9
        {
            public static void One()
            {
                Console.WriteLine("one display");
                throw new Exception("Error");
            }
            public static void Two()
            {
                Console.WriteLine("Two display");
            }
        }

           delegate void DelegateException();

    class S10
        {
            

            static void Main(string[] args)
            {

            DelegateException obj = new DelegateException (S9.One);  // Delegate instantiation 
                obj += S9.Two;

                Delegate[] del = obj.GetInvocationList();

                foreach (DelegateException d in del)
                {
                    try
                    {
                        d();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error caught");
                    }
                }
                Console.Read();
            }
        }
    
}
