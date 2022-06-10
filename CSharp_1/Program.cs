using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            People p = new People();
            Student s = new Student();
            People pc = s;
            p.HideFun();
            s.HideFun();
            pc.HideFun();
            Console.ReadKey();
        }
        class People
        {
            public void HideFun()
            {
                Console.WriteLine("人类的HideFun方法");
            }
        }
        class Student:People
        {
            public void HideFun()
            {
                Console.WriteLine("学生类的HideFun方法");
            }
        }
    }
}
