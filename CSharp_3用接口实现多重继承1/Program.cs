using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3用接口实现多重继承1
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.CanbeEaten();
            duck.CanFly();
            duck.CanSwimming();
            duck.LittleAnimal();
            Console.ReadKey();
        }
    }
    interface Animal
    {
        void LittleAnimal();
    }
    interface Bird1
    {
        void CanFly();
    }

    abstract class Bird2
    {
        public abstract void CanFly();
    }

    interface Swim
    {
        void CanSwimming();
    }
    interface Food
    {
        void CanbeEaten();
    }

    class Duck : Bird2, Animal, Swim, Food
    {
        public void LittleAnimal()
        {
            Console.WriteLine("鸭子是一个小动物.");
        }
        public void CanSwimming()
        {
            Console.WriteLine("鸭子会游泳.");
        }
        public void CanbeEaten()
        {
            Console.WriteLine("鸭子可以做成北京烤鸭吃.");
        }
        //public void CanFly()
        //{
        //    Console.WriteLine("鸭子可以飞");
        //}
        public override void CanFly()
        {
            Console.WriteLine("鸭子会飞哦。");
        }
    }
}
