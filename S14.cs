using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void LinkToEventHandler();
    class Client1
    {
        string name;
        public Client1(string nameArgs)
        {
            name = nameArgs;
        }
        public void Client1EventHandler()
        {
            Console.WriteLine("EventHandler called for object {0}", name);
        }
    }

    class EventGeneratorClass
    {
        public static event LinkToEventHandler Evt;
        static void Main(string[] args)
        {
            Client1 c1 = new Client1("object c1 of Client1 class");
            Evt += new LinkToEventHandler(c1.Client1EventHandler);
            DoSomething(); // invoking(step 3)
            Console.Read();
        }

        public static void DoSomething()
        {
            System.Console.WriteLine("Something Happened! We need to send an event.");
            SendEvent();
        }

        public static void SendEvent()
        {
            if (Evt != null)
            {
                Evt();
            }
        }
    }
}
