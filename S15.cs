using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void LinkToEventHandler1();

    class Client2
    {
        string name;
        public Client2(string nameArg)
        {
            name = nameArg;
        }
        public void Client2EventHandler()
        {
            System.Console.WriteLine("EventHandler Called for object {0}", name);
        }
    }

    class EventGeneratorClass1
    {
        public static event LinkToEventHandler1 Evt;

        public static void Main()
        {
            Client2 c1_o1 = new Client2("Object1 of Client1 class");
            Client2 c1_o2 = new Client2("Object2 of Client1 class");
            Client2 c1_o3 = new Client2("Object3 of Client1 class");
            Evt += new LinkToEventHandler1(c1_o1.Client2EventHandler);
            Evt += new LinkToEventHandler1(c1_o2.Client2EventHandler);
            Evt += new LinkToEventHandler1(c1_o3.Client2EventHandler);
            DoSomething();
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
