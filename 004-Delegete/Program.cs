using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Delegete
{
    class Program
    {
        //定义了一个委托类型，这个委托类型的名字叫做GetAStringency
        private delegate string GetAString();
        static void Main(string[] args)
        {
            #region 委托的声明及其调用
            //int x = 40;

            ////声明：
            ////方法一：给委托加方法
            ////GetAString a = new GetAString(x.ToString); //a指向了x中的ToString方法

            ////方法二：
            //GetAString a = x.ToString;

            ////调用：
            ////委托的调用方法一：
            ////string s = a(); //通过委托实例去调用x中的tostring方法

            ////委托的调用方法二：通过Invoke方法去调用a所引用的方法
            //string s = a.Invoke();


            //Console.WriteLine(s); //通过委托类型调用一个方法，跟直接调用这个方法作用是一样的
            //Console.ReadKey();
            #endregion

            #region 实例二：使用委托类型作为方法的参数
            PrintString method = Method1;
            PrintStr(method);
            method = Method2;
            PrintStr(method);
            Console.ReadKey();
            #endregion
        }

        //一个例子：委托可以作为方法来传递
        private delegate void PrintString();
        static void PrintStr(PrintString print)
        {
            print();
        }
        static void Method1()
        {
            Console.WriteLine("Method 1");
        }
        static void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
