using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_5事件应用
{
    public delegate void MyD(string mess);
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Receiver receiver1 = new Receiver("李华");
            Receiver receiver2 = new Receiver("王五");
            publisher.Event += receiver1.Method;
            publisher.Event += receiver2.Method;
            publisher.FireEvent("面试的时间到了");
            Console.ReadKey();
        }
    }
    //事件的发送者
    public class Publisher
    {
        public event MyD Event;
        public void FireEvent(string notice)
        {
            if (Event != null) Event(notice);
        }
    }
    //事件的接收者
    public class Receiver
    {
        string _name;
        public Receiver(string name)
        {
            _name = name;
        }
        public void Method(string s)
        {
            Console.WriteLine(string.Format("通知{0},{1}", _name, s));
        }
    }
}
