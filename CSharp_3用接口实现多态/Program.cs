using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3用接口实现多态
{
    class Program
    {
        static void Main(string[] args)
        {
            Run[] runs = new Run[3];
            runs[0] = new Cat();
            runs[1] = new Dog();
            runs[2] = new Monkey();
            foreach(var r1 in runs)
            {
                r1.Run();
            }
            Console.ReadKey();
        }
    }
    public interface Run
    {
        void Run();
    }
    class Cat:Run
    {
        public void Run()
        {
            Console.WriteLine("小猫可以在屋檐上奔跑！");
        }
    }
    class Dog : Run
    {
        public void Run()
        {
            Console.WriteLine("小狗可以在原野上奔跑!");
        }
    }
    class Monkey:Run
    {
        public void Run()
        {
            Console.WriteLine("猴子可以在树林间奔跑!");
        }
    }
}
