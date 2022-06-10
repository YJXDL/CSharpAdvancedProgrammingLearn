using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_3用类实现接口的应用
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint p = new MyPoint(1, 2, 3);
            Console.WriteLine("X = {0},Y={1},Z={2}", p.X, p.Y, p.Z);
            Console.ReadLine();
        }
    }
    interface IPoint
    {
        int X
        {
            get;
            set;
        }
        int Y
        {
            get;
            set;
        }
        int Z
        {
            get;
            set;
        }
    }
    class MyPoint : IPoint
    {
        private int myX;
        private int myY;
        private int myZ;
        public MyPoint(int x, int y, int z)
        {
            myX = x;
            myY = y;
            myZ = z;
        }
        //实现IPoint接口中的属性
        public int X
        {
            get
            {
                return myX;
            }
            set
            {
                myX = value;
            }
        }
        public int Y
        {
            get
            {
                return myY;
            }
            set
            {
                myY = value;
            }
        }
        public int Z
        {
            get
            {
                return myZ;
            }
            set
            {
                myZ = value;
            }
        }
    }
}
