using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_反射和特性
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //每一个类对应一个type对象，这个type对象存储了这个类有哪些方法跟哪些数据哪些成员
            MyClass my = new MyClass();
            Type type = my.GetType();//通过对象获取这个对象所属类的Type对象
                                     //MessageBox.Show(type.Name);
                                     //MessageBox.Show(type.Namespace);
                                     //MessageBox.Show(type.Assembly.ToString());

            //FieldInfo[] array = type.GetFields();
            //foreach (FieldInfo info in array)
            //{
            //    MessageBox.Show(info.Name+" ");
            //}
            //PropertyInfo[] array2 = type.GetProperties();
            //foreach(PropertyInfo info in array2)
            //{
            //    MessageBox.Show(info.Name + " ");
            //}
            //MethodInfo[] array3 =  type.GetMethods();
            // foreach(MethodInfo info in array3 )
            // {
            //     MessageBox.Show(info.Name + "");
            // }

            Assembly assem = my.GetType().Assembly;//通过Type对象获取它所在的程序集Assembly
        }
    }
}
