using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3接口的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            Button bt = new Button();
            bt.On();
            bt.Off();
            onOffSwitch oos = new onOffSwitch();
            oos.On();
            oos.Off();
            Console.ReadKey();
        }
        public interface ISwitch
        {
            void On();
            void Off();
        }
        public class onOffSwitch:ISwitch
        {
            public void On()
            {
                Console.WriteLine("顺时针转动！");
            }
            public void Off()
            {
                Console.WriteLine("逆时针转动！");
            }
        }
        public class Button:ISwitch
        {
            public void On()
            {
                Console.WriteLine("开启！");
            }
            public void Off()
            {
                Console.WriteLine("关闭！");
            }
        }
    }
}
