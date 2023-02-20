using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_6索引器的应用一
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);
            Console.WriteLine(p[2]);
            Console.ReadKey();
        }
    }
    class Point
    {
        private float x, y, z;
        //定义索引器，使得可以使用数组的方式访问Vector的数据
        public float this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    //若访问下标超出范围，抛出异常
                    default:
                        throw new IndexOutOfRangeException("下标超出范围");

                }
            }
            set
            {
                switch(i)
                {
                    case 0:
                        x = value;break;
                    case 1:
                        y = value;break;
                    case 2:
                        z = value;break;
                    default:
                        throw new IndexOutOfRangeException("下标超出范围");
                }
            }
        }
    }
}
