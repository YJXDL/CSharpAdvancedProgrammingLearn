using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterList = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster(){ Id = 100,Age =100,Kongfu = "葵花宝典",Level=1 }
            };
        }
    }
}
