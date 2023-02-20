using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 创建型模式1
{
    public class Namer
    {
        protected string frName, lName;
        public string getFrname()
        {
            return frName;
        }
        public string getLname()
        {
            return lName;
        }
    }

    public class FirstFirst:Namer
    {
        public FirstFirst(string name)
        {
            int i = name.Trim().IndexOf(" ");
            if(i>0)
            {
                frName = name.Substring(0, i).Trim();
                lName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }
}
