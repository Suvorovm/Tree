using System;
using System.Diagnostics;
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

        private void SearchNExt(string value)
        {
            int num = -1;
            string valueFounded;
            while (num+1< listBox1.Items.Count) { 

            num = listBox1.FindStringExact(value, ++num);
            valueFounded = listBox1.Items[num].ToString();
            if (String.Compare(valueFounded, value, StringComparison.Ordinal) == 0)
            {
                listBox1.SetSelected(num, true);
            }
              
        }   
            
            Debug.WriteLine("Exit");
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
                //Метод FindStringExact not case-sensitive. Не поддерживает регистре.              
                SearchNExt(str);

            }
            else
            {
                label4.Text = "Не найдено";
                listBox1.SelectedIndex = -1;
            }
        }
    }
}
