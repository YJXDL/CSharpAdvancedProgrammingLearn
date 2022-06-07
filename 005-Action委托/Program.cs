using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Action委托
{
    class Program
    {
        static void PrintString()
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintInt(int i)
        {
            Console.WriteLine(i);
        }
        static void PrintString(string str)
        {
            Console.WriteLine(str);
        }
        static void PrintDoubleInt(int i1,int i2)
        {
            Console.WriteLine(i1 + i2);
        }
        static void Main(string[] args)
        {
            int x = 100;
            Action a = PrintString; //Action是系统内置(预定义)的一个委托类型，它可以指向一个没有返回值没有参数的方法
            Action<int> b = PrintInt;//定义了一个委托类型，这个类型可以指向一个没有返回值，有一个int参数的方法
            Action<string> c = PrintString;//定义一个委托类型，这个类型可以指向一个没有返回值，有一个string参数的方法 在这里系统回自动寻找匹配的方法。
            Action<int, int> d = PrintDoubleInt;
            //Action后面可以通过泛型去指定action去指定方法的多个参数类型，参数的类型跟action后面声明的委托类型是对应着的
            a();
            b(3);
            c("I AM BEAUTIFUL!");
            d(55, 55);
            Console.ReadKey();
        }       
    }
}
