using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3用类实现接口的应用2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.AnimalFun();
            Student student = new Student();
            student.AnimalFun();
            student.PeopleFun();
            Console.ReadLine();
        }
    }
    interface IAnimal
    {
        void AnimalFun();
    }
    interface People:IAnimal
    {
        void PeopleFun();
    }
    class Dog:IAnimal
    {
        public void AnimalFun()
        {
            Console.WriteLine("Dog类实现Animal接口的AnimalFun()");
        }
    }
    class Student :People
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
