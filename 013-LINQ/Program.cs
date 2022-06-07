


using System;
using System.Collections.Generic;
using System.Linq;

namespace _013_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterList = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster(){ Id = 1,Name = "黄蓉",Age =18,MenPai = "丐帮",Kongfu="打狗棒法",Level=9 },
                new MartialArtsMaster(){ Id = 2,Name = "郭靖",Age =18,MenPai = "丐帮",Kongfu="降龙十八掌",Level=10 },
                new MartialArtsMaster(){ Id = 3,Name = "东方不败",Age =20,MenPai = "明教",Kongfu="葵花宝典",Level=10 },
                 new MartialArtsMaster(){ Id = 4,Name = "令狐冲",Age =20,MenPai = "华山",Kongfu="独孤九剑",Level=10 },
                 new MartialArtsMaster(){ Id = 5,Name = "黄药师",Age =20,MenPai = "梅花岛",Kongfu="弹指神通",Level=10 },
                  new MartialArtsMaster(){ Id = 6,Name = "洪七公",Age =20,MenPai = "丐帮",Kongfu="打狗棒法",Level=10 },
                  new MartialArtsMaster(){ Id = 7,Name = "任我行",Age =20,MenPai = "明教",Kongfu="葵花宝典",Level=1 }

            };
            var kongfuList = new List<Kongfu>()
            {
                new Kongfu(){Id = 1,Name="打狗棒法",Power=90 },
                new Kongfu() {Id=2,Name ="降龙十八掌",Power=100},
                new Kongfu(){Id=3,Name="葵花宝典",Power=88},
                new Kongfu(){Id=4,Name="独孤九剑",Power=88},
                new Kongfu(){Id=5,Name="九阴真经",Power=88},
                new Kongfu(){Id=6,Name="弹指神通",Power=88}
            };
            //查寻所有武学级别大于8的武林高手
            //var res = new List<MartialArtsMaster>();
            //foreach(var temp in masterList)
            //{
            //    if(temp.Level>8)
            //    {
            //        res.Add(temp);
            //    }
            //}

            //1、使用LINQ做查询（表达式写法）
            var res = from m in masterList //from 设置查询的集合
                      where m.Level > 8 && m.MenPai == "丐帮"//where 后面加查询的条件，通过&&添加并列的条件
                      select m.Name; //输出想要的数据
            //2、扩展方法的写法
            //var res1 =  masterList.Where(Test1); 
            var res1 = masterList.Where(m => m.Level > 8 && m.MenPai == "丐帮"); //使用Lambda表达式的方式

            //3、LINQ联合查询
            var res2 = from m in masterList
                       from k in kongfuList
                       where m.Kongfu == k.Name && k.Power >= 88
                       // select new { master = m, kongfu = k }
                       select m;
            //4、扩展方法
            var res3 = masterList.SelectMany(m => kongfuList, (m, k) => new { master = m, kongfu = k }).Where(x => x.master.Kongfu == x.kongfu.Name && x.kongfu.Power > 90);


            foreach (var temp in res3)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }
        /// <summary>
        /// 过滤方法
        /// </summary>
        static bool Test1(MartialArtsMaster master)
        {
            if (master.Level > 8)
            {
                return true;
            }
            return false;
        }
    }
}
