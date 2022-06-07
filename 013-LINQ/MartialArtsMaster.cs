using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_LINQ
{
    /// <summary>
    /// 武林高手
    /// </summary>
    class MartialArtsMaster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MenPai { get; set; }
        public string Kongfu { get; set; }
        public int Level { get; set; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Age)}={Age.ToString()}, {nameof(MenPai)}={MenPai}, {nameof(Kongfu)}={Kongfu}, {nameof(Level)}={Level.ToString()}}}";
        }



        //public override string ToString()
        //{
        //    return "编号："+Id.ToString()  + " 姓名：" + Name;
        //}
    }
}
