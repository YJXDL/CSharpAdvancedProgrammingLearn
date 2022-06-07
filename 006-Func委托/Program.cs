using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Func委托
{
    class Program
    {
        static int Test1()
        {
            return 1;
        }
        static int Test2(string str)
        {
            Console.WriteLine(str);
            return 100;
        }
        static int Test3(int i, int j)
        {
            return i + j;
        }
        static void Main(string[] args)
        {
            //Func<int> a = Test1;//func中的泛型类型指定的是方法的返回值类型
            //Console.WriteLine(a());
            //Console.ReadKey();

            //Func<string, int> b = Test2;
            //Console.WriteLine(b.Invoke("你好呀"));
            //Console.ReadKey();

            //Func后面必须指定一个返回值类型，参数类型可以有0-16个，先写参数类型，最后一个是返回值类型
            //案例1：delegate double DoubleOp(double x) == Func<double,double>
            Func<int, int, int> c = Test3;
            Console.WriteLine(c(1, 5)); // == Console.WriteLine(c.Invoke(1, 5));
            Console.ReadKey();
        }
    }
}
