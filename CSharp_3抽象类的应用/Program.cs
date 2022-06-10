using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3抽象类的应用
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.animal();
            Duck duck = new Duck();
            duck.animal();
            duck.Fly();
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract void animal();
    }
    public interface Fly
    {
        void Fly();
    }
    public class Cat : Animal
    {
        public override void animal()
        {
            Console.WriteLine("猫是一种可爱的小动物!");
        }
    }
    public class Duck : Animal, Fly
    {
        public override void animal()
        {
            Console.WriteLine("鸭子是禽类动物!");
        }
        public void Fly()
        {
            Console.WriteLine("鸭子会飞哦！");
        }
    }


}
