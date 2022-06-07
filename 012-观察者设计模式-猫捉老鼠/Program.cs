using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_观察者设计模式_猫捉老鼠
{
    //事件是基于委托，为委托提供了一个发布/订阅机制，我们可以说事件是一种具有特殊签名的委托。
    //什么是事件？
    /*
     *事件是类过对象向其他类火对象通知发生的事情的一种特殊签名的委托。
     *事件的声明：
     *public Event 委托类型 事件名
     *事件使用event关键字来声明 它的返回值是一个委托类型
     *通常事件的命名，以名字+Event作为它的名称，在编码中尽量使用规范命名，增加代码的可读性。
    */

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲猫", "黄色");
            Mouse mouse1 = new Mouse("米奇", "黑色", cat);
            //cat.catCome += mouse1.RunAway;
            Mouse mouse2 = new Mouse("唐老鸭", "白色", cat);
            // cat.catCome += mouse2.RunAway;
            Mouse mouse3 = new Mouse("小树", "绿色", cat);
            // cat.catCome += mouse3.RunAway;
            Mouse mouse4 = new Mouse("舒克", "黑白", cat);
            // cat.catCome += mouse4.RunAway;
            // cat.CatComing(mouse1,mouse2);//猫的状态改变,在cat中调用了观察者的方法，当观察者发生改变的时候，需要同时修改被观察者的代码。
            cat.CatComing();
            //cat.catCome(); 
            Console.ReadKey();
        }
    }
}
