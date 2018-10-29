using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree
{
    public partial class Form1 : Form
    {
        DoubleList list = new DoubleList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            list.AddWord(str);

            listView1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            if (list.SerchWord(str))
            {
                label4.Text = "Найдено";
                listView1.Items[0].Focused = true;
                listView1.Items[0].Selected = true;
             
            }
            else
            {
                label4.Text = "Не найдено";
            }
        }
    }
}
