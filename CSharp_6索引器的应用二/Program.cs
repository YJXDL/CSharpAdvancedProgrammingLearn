using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_6索引器的应用二
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个容量为3的相册
            Framework friends = new Framework(3);
            //创建3张照片
            Picture first = new Picture("幼年照片");
            Picture second = new Picture("成年照片");
            Picture third = new Picture("老年照片");
            //向相册加载照片
            friends[0] = first;
            friends[1] = second;
            friends[2] = third;
            //按索引检索
            Picture p1 = friends[2];
            Console.WriteLine(p1.Title);
            //按名称索引
            Picture p2 = friends["幼年照片"];
            Console.WriteLine(p2.Title);
            Console.ReadKey();
        }
    }
    class Picture
    {
        string _title;
        public Picture(string title)
        {
            this._title = title;
        }
        public string  Title
        {
            get
            {
                return _title;
            }
        }
    }
    class Framework
    {
        //该数组用于存放照片
        Picture[] pictures;
        public Framework(int capacity)
        {
            pictures = new Picture[capacity];
        }
        //用整型的序号作为下标的索引器
        public Picture this[int index]
        {
            get
            {
                //验证索引范围
                if(index<0||index>=pictures.Length)
                {
                    Console.WriteLine("索引无效");
                    //使用null指示失败
                    return null;
                }
                return pictures[index];
            }
            set
            {
                if(index<0||index>=pictures.Length)
                {
                    Console.WriteLine("索引无效");
                    return;
                }
                pictures[index] = value;
            }
        }
        public Picture this[string title]
        {
            get
            {
                //遍历数组中的所有照片
                foreach(Picture p in pictures)
                {
                    //将图片中的标题与索引器参数进行比较
                    if (p.Title == title)
                        return p;
                }
                Console.WriteLine("未找到");

                //使用null指示失败
                return null;
            }

        }
    }
}
