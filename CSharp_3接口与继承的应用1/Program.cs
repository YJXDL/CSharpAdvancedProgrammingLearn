using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3接口与继承的应用1
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现接口的Animal的类Dog
            Animal a = new Dog();
            //运行错误，抛出InvalidCastException异常
            //People p = (People)a;
            //实现接口People的类Student,People接口从Animal接口继承
            Animal a1 = new Student();
            a1.AnimalFun();
            People p1 = (People)(a1);
            p1.PeopleFun();
            People p2 = new Student();
            p2.PeopleFun();
            Animal a2 = (Animal)p2;
            a2.AnimalFun();
            Console.ReadKey();
        }
        interface Animal
        {
            void AnimalFun();
        }
        interface People:Animal
        {
            void PeopleFun();
        }
        class Dog:Animal
        {
            public void AnimalFun()
            {
                Console.WriteLine("Dog类实现Animal接口的AnimalFun()");
            }
        }
        class Student:People
        {
            public void AnimalFun()
            {
                Console.WriteLine("Student类实现Animal接口的AnimalFun()");
            }
            public void PeopleFun()
            {
                Console.WriteLine("Student类实现People接口的PeopleFun()");
            }
        }
    }
}
