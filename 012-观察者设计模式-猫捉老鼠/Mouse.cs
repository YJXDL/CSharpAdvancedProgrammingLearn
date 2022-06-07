using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者设计模式_猫捉老鼠
{
    class Mouse
    {
        private string name;
        private string color;
        public Mouse(string name, string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome += this.RunAway;//把自身的逃跑方法注册进猫里面，订阅消息
        }
        public void RunAway()
        {
            Console.WriteLine(color + "的老鼠" + name + "说：老猫来了，赶紧跑");
        }

    }
}
