using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_2运算符重载的应用2
{
    class Program
    {
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
                return string.Format("x坐标：{0},y坐标：{1}", X, Y);
            }
        }
        class ThreeD : TwoD
        {
            private int z;
            public ThreeD() : base() { z = 0; }
            public ThreeD(int a, int b, int c) : base(a, b)
            {
                z = c;
            }
            public int Z
            {
                get
                {
                    return z;
                }
            }
            public static ThreeD operator +(ThreeD op1, ThreeD op2)
            {
                ThreeD result = new ThreeD(op1.X + op2.X, op1.Y + op2.Y, op1.z + op2.z);
                return result;
            }
            public static ThreeD operator ++(ThreeD op1)
            {
                ThreeD result = new ThreeD(op1.X + 1, op1.Y + 1, op1.z + 1);
                return result;
            }
            public static bool operator ==(ThreeD op1, ThreeD op2)
            {
                if ((op1.X == op2.X) && (op1.Y == op2.Y) && (op1.z == op2.z))
                    return true;
                else
                    return false;
            }
            public static bool operator !=(ThreeD op1, ThreeD op2)
            {
                if ((op1.X != op2.X) || (op1.Y != op2.Y) || (op1.z != op2.z))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public override string ToString()
            {
                return string.Format("{0},z坐标：{1}", base.ToString(), z);
            }
        }
        static void Main(string[] args)
        {
            ThreeD threeD1 = new ThreeD(1, 2, 3);
            ThreeD threeD2 = new ThreeD(3, 2, 1);
            ThreeD threeD3 = threeD1 + threeD2;
            if (threeD1 == threeD2)
            {
                Console.WriteLine("这两个数值一样！");
            }
            else
            {
                Console.WriteLine("这两个数值不同");
            }
            Console.WriteLine(threeD3);
            Console.ReadKey();
        }
    }
}
