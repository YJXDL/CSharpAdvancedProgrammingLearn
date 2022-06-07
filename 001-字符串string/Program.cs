using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_字符串string
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "www.devsiki.com";//我们使用string类型去存储字符串类，字符串需要使用双引号引起来
            int length = s.Length;//我们通过length获取长度
            Console.Write(length);
            Console.ReadKey();
        }
    }
}
