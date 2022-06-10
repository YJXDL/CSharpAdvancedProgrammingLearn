using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2运算符重载的应用
{
    class Program
    {
        /// <summary>
        /// 在这个程序中，+号被重载，被重载的+号可以用来计算TwoD类型对象的相加，还可以计算TwoD类型对象与整数类型的相加操作。
        /// </summary>
        class TwoD
        {
            private int x;
            public int X
            {
                get
                {
                    return x;
                }
            }
            private int y;
            public int Y
            {
                get
                {
                    return y;
                }
            }
            public TwoD()
            {
                x = y = 0;
            }
            public TwoD(int a, int b)
            {
                x = a;
                y = b;
            }
            public static TwoD operator +(TwoD op1, TwoD op2)
            {
                TwoD result = new TwoD();
                result.x = op1.x + op2.x;
                result.y = op1.y + op2.y;
                return result;
            }
            public static TwoD operator +(TwoD op1, int op2)
            {
                TwoD result = new TwoD();
                result.x = op1.x + op2;
                result.y += op1.x + op2;
                return result;
            }

            public override string ToString()
            {
                return string.Format("x坐标：{0},y坐标：{1}",X, Y);
            }
        }
        static void Main(string[] args)
        {
            TwoD t1 = new TwoD(1, 2);
            TwoD t2 = new TwoD(3, 2);
            t1 = t1 + t2;
            Console.WriteLine(t1);
            Console.ReadKey();
        }
    }
}
