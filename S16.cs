using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void LinkToEventHandler1_1(int i);

    class MaleStudent
    {
        string name;
        int Marks;

        public MaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                System.Console.WriteLine("{0} Got Admission. He must pay fees", name);
            else
                System.Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);
        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    class FemaleStudent
    {
        string name;
        int Marks;

        public FemaleStudent(string nameArg, int marks)
        {
            name = nameArg;
            Marks = marks;
        }
        public void MyActionItem(int i)
        {
            if (i == 1)
                System.Console.WriteLine("{0} got Admission. He must pay fees", name);
            else
                System.Console.WriteLine(
                  "{0} did not Get Admission. He must lookout for other college", name);

        }
        public int GetMarks()
        {
            return Marks;
        }
    }

    class EventGeneratorClass5
    {
        public static event LinkToEventHandler1_1 AdmissionDeniedEvt;
        public static event LinkToEventHandler1_1 AdmissionGrantedEvt;

        public static void Main()
        {
            MaleStudent Jay = new MaleStudent("Jay", 95);
            MaleStudent Ajay = new MaleStudent("Ajay", 89);
            MaleStudent Akhil = new MaleStudent("Akhil", 91);

            FemaleStudent Shina = new FemaleStudent("Shina", 92);
            FemaleStudent Heena = new FemaleStudent("Heena", 88);
            FemaleStudent Pooja = new FemaleStudent("Pooa", 91);

            if (Jay.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler1_1(Jay.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler1_1(Jay.MyActionItem);

            if (Ajay.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler1_1(Ajay.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler1_1(Ajay.MyActionItem);

            if (Akhil.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler1_1(Akhil.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler1_1(Akhil.MyActionItem);

            if (Shina.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler1_1(Shina.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler1_1(Shina.MyActionItem);

            if (Heena.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler1_1(Heena.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler1_1(Heena.MyActionItem);

            if (Pooja.GetMarks() >= 90)
                AdmissionGrantedEvt += new LinkToEventHandler1_1(Pooja.MyActionItem);
            else
                AdmissionDeniedEvt += new LinkToEventHandler1_1(Pooja.MyActionItem);

            SendEvent2();
            Console.Read();
        }

        public static void SendEvent2()
        {
            if (AdmissionGrantedEvt != null)
            {
                AdmissionGrantedEvt(1);
            }

            if (AdmissionDeniedEvt != null)
            {
                AdmissionDeniedEvt(0);
            }
        }
    }
}
