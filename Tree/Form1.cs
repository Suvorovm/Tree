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
            if (list.SerchWord(str))
            {
                list.AddWord(str);
                label4.Text = "Эллемент уже существует";
            }
            else
            {
                list.AddWord(str);
                listBox1.Items.Add(str);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            if (list.SerchWord(str))
            {
                label4.Text = "Найдено";
                //Метод FindString not case-sensitive.
                int numer =  listBox1.FindStringExact(str);
                listBox1.SetSelected(numer, true);
             

            }
            else
            {
                label4.Text = "Не найдено";
                listBox1.SelectedIndex = -1;
            }
        }
    }
}
